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
    public class VillaBuildingsController : Controller
    {
        private readonly InsuranceRiskAssessmentDbContext _context;

        public VillaBuildingsController(InsuranceRiskAssessmentDbContext context)
        {
            _context = context;
        }

        // GET: VillaBuildings
        public async Task<IActionResult> Index()
        {
            return View(await _context.VillaBuildings.ToListAsync());
        }

        // GET: VillaBuildings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var villaBuilding = await _context.VillaBuildings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (villaBuilding == null)
            {
                return NotFound();
            }

            return View(villaBuilding);
        }

        // GET: VillaBuildings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VillaBuildings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Country,Region,City,Address,FireExtinguishers,EmergencyExit,SquareFeet,AlarmSystem,GasBottles,Id,CreatedAt,ModifiedAt,PreviousAccidents")] VillaBuilding villaBuilding)
        {
            if (ModelState.IsValid)
            {
                _context.Add(villaBuilding);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(villaBuilding);
        }

        // GET: VillaBuildings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var villaBuilding = await _context.VillaBuildings.FindAsync(id);
            if (villaBuilding == null)
            {
                return NotFound();
            }
            return View(villaBuilding);
        }

        // POST: VillaBuildings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Country,Region,City,Address,FireExtinguishers,EmergencyExit,SquareFeet,AlarmSystem,GasBottles,Id,CreatedAt,ModifiedAt,PreviousAccidents")] VillaBuilding villaBuilding)
        {
            if (id != villaBuilding.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(villaBuilding);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VillaBuildingExists(villaBuilding.Id))
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
            return View(villaBuilding);
        }

        // GET: VillaBuildings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var villaBuilding = await _context.VillaBuildings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (villaBuilding == null)
            {
                return NotFound();
            }

            return View(villaBuilding);
        }

        // POST: VillaBuildings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var villaBuilding = await _context.VillaBuildings.FindAsync(id);
            _context.VillaBuildings.Remove(villaBuilding);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VillaBuildingExists(int id)
        {
            return _context.VillaBuildings.Any(e => e.Id == id);
        }
    }
}
