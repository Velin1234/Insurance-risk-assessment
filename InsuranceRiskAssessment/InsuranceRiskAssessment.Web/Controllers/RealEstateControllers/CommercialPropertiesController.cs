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
    public class CommercialPropertiesController : Controller
    {
        private readonly InsuranceRiskAssessmentDbContext _context;

        public CommercialPropertiesController(InsuranceRiskAssessmentDbContext context)
        {
            _context = context;
        }

        // GET: CommercialProperties
        public async Task<IActionResult> Index()
        {
            return View(await _context.CommercialProperties.ToListAsync());
        }

        // GET: CommercialProperties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commercialProperty = await _context.CommercialProperties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commercialProperty == null)
            {
                return NotFound();
            }

            return View(commercialProperty);
        }

        // GET: CommercialProperties/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CommercialProperties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Country,Region,City,Address,FireExtinguishers,EmergencyExit,SquareFeet,AlarmSystem,GasBottles,Id,CreatedAt,ModifiedAt,PreviousAccidents")] CommercialProperty commercialProperty)
        {
            if (ModelState.IsValid)
            {
                _context.Add(commercialProperty);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(commercialProperty);
        }

        // GET: CommercialProperties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commercialProperty = await _context.CommercialProperties.FindAsync(id);
            if (commercialProperty == null)
            {
                return NotFound();
            }
            return View(commercialProperty);
        }

        // POST: CommercialProperties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Country,Region,City,Address,FireExtinguishers,EmergencyExit,SquareFeet,AlarmSystem,GasBottles,Id,CreatedAt,ModifiedAt,PreviousAccidents")] CommercialProperty commercialProperty)
        {
            if (id != commercialProperty.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(commercialProperty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommercialPropertyExists(commercialProperty.Id))
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
            return View(commercialProperty);
        }

        // GET: CommercialProperties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var commercialProperty = await _context.CommercialProperties
                .FirstOrDefaultAsync(m => m.Id == id);
            if (commercialProperty == null)
            {
                return NotFound();
            }

            return View(commercialProperty);
        }

        // POST: CommercialProperties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var commercialProperty = await _context.CommercialProperties.FindAsync(id);
            _context.CommercialProperties.Remove(commercialProperty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CommercialPropertyExists(int id)
        {
            return _context.CommercialProperties.Any(e => e.Id == id);
        }
    }
}
