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
    public class ResidentialBuildingsController : Controller
    {
        private readonly InsuranceRiskAssessmentDbContext _context;

        public ResidentialBuildingsController(InsuranceRiskAssessmentDbContext context)
        {
            _context = context;
        }

        // GET: ResidentialBuildings
        public async Task<IActionResult> Index()
        {
            return View(await _context.ResidentialBuildings.ToListAsync());
        }

        // GET: ResidentialBuildings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentialBuilding = await _context.ResidentialBuildings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residentialBuilding == null)
            {
                return NotFound();
            }

            return View(residentialBuilding);
        }

        // GET: ResidentialBuildings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ResidentialBuildings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Floor,Country,Region,City,Address,FireExtinguishers,EmergencyExit,SquareFeet,AlarmSystem,GasBottles,Id,CreatedAt,ModifiedAt,PreviousAccidents")] ResidentialBuilding residentialBuilding)
        {
            if (ModelState.IsValid)
            {
                _context.Add(residentialBuilding);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(residentialBuilding);
        }

        // GET: ResidentialBuildings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentialBuilding = await _context.ResidentialBuildings.FindAsync(id);
            if (residentialBuilding == null)
            {
                return NotFound();
            }
            return View(residentialBuilding);
        }

        // POST: ResidentialBuildings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Floor,Country,Region,City,Address,FireExtinguishers,EmergencyExit,SquareFeet,AlarmSystem,GasBottles,Id,CreatedAt,ModifiedAt,PreviousAccidents")] ResidentialBuilding residentialBuilding)
        {
            if (id != residentialBuilding.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(residentialBuilding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ResidentialBuildingExists(residentialBuilding.Id))
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
            return View(residentialBuilding);
        }

        // GET: ResidentialBuildings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var residentialBuilding = await _context.ResidentialBuildings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (residentialBuilding == null)
            {
                return NotFound();
            }

            return View(residentialBuilding);
        }

        // POST: ResidentialBuildings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var residentialBuilding = await _context.ResidentialBuildings.FindAsync(id);
            _context.ResidentialBuildings.Remove(residentialBuilding);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ResidentialBuildingExists(int id)
        {
            return _context.ResidentialBuildings.Any(e => e.Id == id);
        }
    }
}
