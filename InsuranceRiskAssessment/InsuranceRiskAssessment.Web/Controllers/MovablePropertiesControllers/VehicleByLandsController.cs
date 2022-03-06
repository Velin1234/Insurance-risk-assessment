using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InsuranceRiskAssessment.DataAccessLayer.Data;
using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;

namespace InsuranceRiskAssessment.Web.Controllers.MovablePropertiesControllers
{
    public class VehicleByLandsController : Controller
    {
        private readonly InsuranceRiskAssessmentDbContext _context;

        public VehicleByLandsController(InsuranceRiskAssessmentDbContext context)
        {
            _context = context;
        }

        // GET: VehicleByLands
        public async Task<IActionResult> Index()
        {
            return View(await _context.VehiclesByLand.ToListAsync());
        }

        // GET: VehicleByLands/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleByLand = await _context.VehiclesByLand
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleByLand == null)
            {
                return NotFound();
            }

            return View(vehicleByLand);
        }

        // GET: VehicleByLands/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VehicleByLands/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FuelType,Parktronic,MostCommonRoutes,RegisterNumber,ManifactureYear,SecurityEquipmenPossession,TechnicalServiceability,DistanceTraveled,Height,Weight,Width,RegisteredCountry,RegisteredRegion,RegisteredCity,Id,CreatedAt,ModifiedAt,PreviousAccidents")] VehicleByLand vehicleByLand)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicleByLand);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicleByLand);
        }

        // GET: VehicleByLands/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleByLand = await _context.VehiclesByLand.FindAsync(id);
            if (vehicleByLand == null)
            {
                return NotFound();
            }
            return View(vehicleByLand);
        }

        // POST: VehicleByLands/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FuelType,Parktronic,MostCommonRoutes,RegisterNumber,ManifactureYear,SecurityEquipmenPossession,TechnicalServiceability,DistanceTraveled,Height,Weight,Width,RegisteredCountry,RegisteredRegion,RegisteredCity,Id,CreatedAt,ModifiedAt,PreviousAccidents")] VehicleByLand vehicleByLand)
        {
            if (id != vehicleByLand.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicleByLand);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleByLandExists(vehicleByLand.Id))
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
            return View(vehicleByLand);
        }

        // GET: VehicleByLands/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicleByLand = await _context.VehiclesByLand
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vehicleByLand == null)
            {
                return NotFound();
            }

            return View(vehicleByLand);
        }

        // POST: VehicleByLands/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicleByLand = await _context.VehiclesByLand.FindAsync(id);
            _context.VehiclesByLand.Remove(vehicleByLand);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleByLandExists(int id)
        {
            return _context.VehiclesByLand.Any(e => e.Id == id);
        }
    }
}
