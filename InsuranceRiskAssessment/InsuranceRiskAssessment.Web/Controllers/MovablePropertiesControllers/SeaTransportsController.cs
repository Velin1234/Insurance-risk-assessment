using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InsuranceRiskAssessment.DataAccessLayer.Data;
using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.SeaTransport;
using Microsoft.AspNetCore.Http;

namespace InsuranceRiskAssessment.Web.Controllers.MovablePropertiesControllers
{
    public class SeaTransportsController : Controller
    {
        private readonly ISeaTransportService _seaTransportService;

        public SeaTransportsController(ISeaTransportService seaTransportService)
        {
            _seaTransportService = seaTransportService;
        }

        // GET: SeaTransports
        public ActionResult Index()
        {
            List<SeaTransportViewModel> seaTransports = _seaTransportService.GetSeaTransports()
               .Select(item => new SeaTransportViewModel()
               {
                   Id = item.Id,
                   ManifactureYear = item.ManifactureYear,
                   SecurityEquipmenPossession = item.SecurityEquipmenPossession,
                   TechnicalServiceability = item.TechnicalServiceability,
                   DistanceTraveled = item.DistanceTraveled,
                   Height = item.Height,
                   Weight = item.Weight,
                   Width = item.Width,
                   RegisteredCountry = item.RegisteredCountry,
                   RegisteredRegion = item.RegisteredRegion,
                   RegisteredCity = item.RegisteredCity,
                   CreatedAt = item.CreatedAt,
                   ModifiedAt = item.ModifiedAt,
                   PreviousAccidents = item.PreviousAccidents,
                   ClimatZone = item.ClimatZone,
                   Functionality = item.Functionality,
                   TypeOfMovability = item.TypeOfMovability,
                   DoesRoutePassesPirateZones = item.DoesRoutePassesPirateZones,
                   ResultValue = item.ResultValue

               }).ToList();

            return View(seaTransports);
        }

        // GET: SeaTransports/Details/5
        public ActionResult Details(int id)
        {
            var item = _seaTransportService.GetSeaTransportById(id);
            SeaTransportDetailsViewModel model = new SeaTransportDetailsViewModel()
            {
                Id = item.Id,
                ManifactureYear = item.ManifactureYear,
                SecurityEquipmenPossession = item.SecurityEquipmenPossession,
                TechnicalServiceability = item.TechnicalServiceability,
                DistanceTraveled = item.DistanceTraveled,
                Height = item.Height,
                Weight = item.Weight,
                Width = item.Width,
                RegisteredCountry = item.RegisteredCountry,
                RegisteredRegion = item.RegisteredRegion,
                RegisteredCity = item.RegisteredCity,
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt,
                PreviousAccidents = item.PreviousAccidents,
                ClimatZone = item.ClimatZone,
                Functionality = item.Functionality,
                TypeOfMovability = item.TypeOfMovability,
                DoesRoutePassesPirateZones = item.DoesRoutePassesPirateZones,
                ResultValue = item.ResultValue
            };
            return View(model);
        }

        // GET: SeaTransports/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SeaTransports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] SeaTransportAddViewModel model)
        {
            var created = _seaTransportService.CreateSeaTransport(model.ManifactureYear, model.SecurityEquipmenPossession, model.TechnicalServiceability,
                model.DistanceTraveled, model.Height, model.Weight, model.Width, model.RegisteredCountry, model.RegisteredRegion,
                model.RegisteredCity, model.ClimatZone, model.DoesRoutePassesPirateZones, model.Functionality, model.TypeOfMovability);

            if (created)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: SeaTransports/Edit/5
        public ActionResult Edit(int id)
        {
            var entity = _seaTransportService.GetSeaTransportById(id);
            if (entity == null)
            {
                return NotFound();
            }

            SeaTransportDetailsViewModel model = new SeaTransportDetailsViewModel()
            {
                Id = entity.Id,
                ManifactureYear = entity.ManifactureYear,
                SecurityEquipmenPossession = entity.SecurityEquipmenPossession,
                TechnicalServiceability = entity.TechnicalServiceability,
                DistanceTraveled = entity.DistanceTraveled,
                Height = entity.Height,
                Weight = entity.Weight,
                Width = entity.Width,
                RegisteredCountry = entity.RegisteredCountry,
                RegisteredRegion = entity.RegisteredRegion,
                RegisteredCity = entity.RegisteredCity,
                CreatedAt = entity.CreatedAt,
                ModifiedAt = entity.ModifiedAt,
                PreviousAccidents = entity.PreviousAccidents,
                ClimatZone = entity.ClimatZone,
                Functionality = entity.Functionality,
                TypeOfMovability = entity.TypeOfMovability,
                DoesRoutePassesPirateZones = entity.DoesRoutePassesPirateZones,
                ResultValue = entity.ResultValue
            };

            return View(model);
        }

        // POST: SeaTransports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SeaTransportViewModel model)
        {
            var updated = _seaTransportService.UpdateSeaTransport(id, model.ManifactureYear, model.SecurityEquipmenPossession, model.TechnicalServiceability,
                model.DistanceTraveled, model.Height, model.Weight, model.Width, model.RegisteredCountry, model.RegisteredRegion,
                model.RegisteredCity, model.ClimatZone, model.DoesRoutePassesPirateZones, model.Functionality, model.TypeOfMovability);


            if (updated)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: SeaTransports/Delete/5
        public ActionResult Delete(int id)
        {
            var item = _seaTransportService.GetSeaTransportById(id);
            SeaTransportDetailsViewModel model = new SeaTransportDetailsViewModel()
            {
                Id = item.Id,
                ManifactureYear = item.ManifactureYear,
                SecurityEquipmenPossession = item.SecurityEquipmenPossession,
                TechnicalServiceability = item.TechnicalServiceability,
                DistanceTraveled = item.DistanceTraveled,
                Height = item.Height,
                Weight = item.Weight,
                Width = item.Width,
                RegisteredCountry = item.RegisteredCountry,
                RegisteredRegion = item.RegisteredRegion,
                RegisteredCity = item.RegisteredCity,
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt,
                PreviousAccidents = item.PreviousAccidents,
                ClimatZone = item.ClimatZone,
                Functionality = item.Functionality,
                TypeOfMovability = item.TypeOfMovability,
                DoesRoutePassesPirateZones = item.DoesRoutePassesPirateZones,
                ResultValue = item.ResultValue
            };
            return View(model);
        }

        // GET: SeaTransports/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _seaTransportService.Remove(id);
            if (deleted)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
    }
}
