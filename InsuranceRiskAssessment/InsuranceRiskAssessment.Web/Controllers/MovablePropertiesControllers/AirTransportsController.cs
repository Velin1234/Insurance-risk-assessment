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
    public class AirTransportsController : Controller
    {
        private readonly InsuranceRiskAssessmentDbContext _context;

        public AirTransportsController(InsuranceRiskAssessmentDbContext context)
        {
            _context = context;
        }

        // GET: AirTransports
        public async Task<IActionResult> Index()
        {
            return View(await _context.AirTransports.ToListAsync());
        }

        // GET: AirTransports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airTransport = await _context.AirTransports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airTransport == null)
            {
                return NotFound();
            }

            return View(airTransport);
        }

        // GET: AirTransports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AirTransports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClimatZone,Functionality,ManifactureYear,SecurityEquipmenPossession,TechnicalServiceability,DistanceTraveled,Height,Weight,Width,RegisteredCountry,RegisteredRegion,RegisteredCity,Id,CreatedAt,ModifiedAt,PreviousAccidents")] AirTransport airTransport)
        {
            if (ModelState.IsValid)
            {
                _context.Add(airTransport);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(airTransport);
        }

        // GET: AirTransports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airTransport = await _context.AirTransports.FindAsync(id);
            if (airTransport == null)
            {
                return NotFound();
            }
            return View(airTransport);
        }

        // POST: AirTransports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClimatZone,Functionality,ManifactureYear,SecurityEquipmenPossession,TechnicalServiceability,DistanceTraveled,Height,Weight,Width,RegisteredCountry,RegisteredRegion,RegisteredCity,Id,CreatedAt,ModifiedAt,PreviousAccidents")] AirTransport airTransport)
        {
            if (id != airTransport.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(airTransport);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AirTransportExists(airTransport.Id))
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
            return View(airTransport);
        }

        // GET: AirTransports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var airTransport = await _context.AirTransports
                .FirstOrDefaultAsync(m => m.Id == id);
            if (airTransport == null)
            {
                return NotFound();
            }

            return View(airTransport);
        }

        // POST: AirTransports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var airTransport = await _context.AirTransports.FindAsync(id);
            _context.AirTransports.Remove(airTransport);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AirTransportExists(int id)
        {
            return _context.AirTransports.Any(e => e.Id == id);
        }
    }
}
