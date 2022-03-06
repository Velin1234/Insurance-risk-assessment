using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InsuranceRiskAssessment.DataAccessLayer.Data;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;

namespace InsuranceRiskAssessment.Web.Controllers.RealEstateControllers
{
    public class BusinessEnterprisesController : Controller
    {
        private readonly InsuranceRiskAssessmentDbContext _context;

        public BusinessEnterprisesController(InsuranceRiskAssessmentDbContext context)
        {
            _context = context;
        }

        // GET: BusinessEnterprises
        public async Task<IActionResult> Index()
        {
            return View(await _context.BusinessEnterprises.ToListAsync());
        }

        // GET: BusinessEnterprises/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessEnterprise = await _context.BusinessEnterprises
                .FirstOrDefaultAsync(m => m.Id == id);
            if (businessEnterprise == null)
            {
                return NotFound();
            }

            return View(businessEnterprise);
        }

        // GET: BusinessEnterprises/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BusinessEnterprises/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PurposeOfTheEnterprise,Country,Region,City,Address,FireExtinguishers,EmergencyExit,SquareFeet,AlarmSystem,GasBottles,Id,CreatedAt,ModifiedAt,PreviousAccidents")] BusinessEnterprise businessEnterprise)
        {
            if (ModelState.IsValid)
            {
                _context.Add(businessEnterprise);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(businessEnterprise);
        }

        // GET: BusinessEnterprises/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessEnterprise = await _context.BusinessEnterprises.FindAsync(id);
            if (businessEnterprise == null)
            {
                return NotFound();
            }
            return View(businessEnterprise);
        }

        // POST: BusinessEnterprises/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PurposeOfTheEnterprise,Country,Region,City,Address,FireExtinguishers,EmergencyExit,SquareFeet,AlarmSystem,GasBottles,Id,CreatedAt,ModifiedAt,PreviousAccidents")] BusinessEnterprise businessEnterprise)
        {
            if (id != businessEnterprise.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(businessEnterprise);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BusinessEnterpriseExists(businessEnterprise.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(businessEnterprise);
        }

        // GET: BusinessEnterprises/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var businessEnterprise = await _context.BusinessEnterprises
                .FirstOrDefaultAsync(m => m.Id == id);
            if (businessEnterprise == null)
            {
                return NotFound();
            }

            return View(businessEnterprise);
        }

        // POST: BusinessEnterprises/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var businessEnterprise = await _context.BusinessEnterprises.FindAsync(id);
            _context.BusinessEnterprises.Remove(businessEnterprise);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BusinessEnterpriseExists(int id)
        {
            return _context.BusinessEnterprises.Any(e => e.Id == id);
        }
    }
}
