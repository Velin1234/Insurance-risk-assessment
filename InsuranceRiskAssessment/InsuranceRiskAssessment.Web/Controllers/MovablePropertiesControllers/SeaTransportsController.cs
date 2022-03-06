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
    public class SeaTransportsController : Controller
    {
        private readonly InsuranceRiskAssessmentDbContext _context;

        public SeaTransportsController(InsuranceRiskAssessmentDbContext context)
        {
            _context = context;
        }

        // GET: SeaTransports
        public async Task<IActionResult> Index()
        {
            return View(await _context.SeaTransports.ToListAsync());
        }

        // GET: SeaTransports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seaTransport = await _context.SeaTransports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seaTransport == null)
            {
                return NotFound();
            }

            return View(seaTransport);
        }

        // GET: SeaTransports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SeaTransports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClimatZone,DoesRoutePassesPirateZones,Functionality,TypeOfMovability,ManifactureYear,SecurityEquipmenPossession,TechnicalServiceability,DistanceTraveled,Height,Weight,Width,RegisteredCountry,RegisteredRegion,RegisteredCity,Id,CreatedAt,ModifiedAt,PreviousAccidents")] SeaTransport seaTransport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seaTransport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(seaTransport);
        }

        // GET: SeaTransports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seaTransport = await _context.SeaTransports.FindAsync(id);
            if (seaTransport == null)
            {
                return NotFound();
            }
            return View(seaTransport);
        }

        // POST: SeaTransports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClimatZone,DoesRoutePassesPirateZones,Functionality,TypeOfMovability,ManifactureYear,SecurityEquipmenPossession,TechnicalServiceability,DistanceTraveled,Height,Weight,Width,RegisteredCountry,RegisteredRegion,RegisteredCity,Id,CreatedAt,ModifiedAt,PreviousAccidents")] SeaTransport seaTransport)
        {
            if (id != seaTransport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seaTransport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeaTransportExists(seaTransport.Id))
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
            return View(seaTransport);
        }

        // GET: SeaTransports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seaTransport = await _context.SeaTransports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (seaTransport == null)
            {
                return NotFound();
            }

            return View(seaTransport);
        }

        // POST: SeaTransports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seaTransport = await _context.SeaTransports.FindAsync(id);
            _context.SeaTransports.Remove(seaTransport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeaTransportExists(int id)
        {
            return _context.SeaTransports.Any(e => e.Id == id);
        }
    }
}
