using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.AirTransport;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace InsuranceRiskAssessment.Web.Controllers.MovablePropertiesControllers
{
    public class AirTransportsController : Controller
    {
        private readonly IAirTransportService _airTransportService;
        public AirTransportsController(IAirTransportService airTransportService)
        {
            _airTransportService = airTransportService;
        }
        public ActionResult Index()
        {
            List<AirTransportViewModel> airTransports = _airTransportService.GetAirTransports()
                .Select(item => new AirTransportViewModel()
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
                    Functionality = item.Functionality,
                    Name = item.Name,
                    ResultValue = item.ResultValue,
                    InsuranceBroker = item.InsuranceBroker
                }).ToList();

            return View(airTransports);
        }
        public ActionResult Details(int id)
        {
            var item = _airTransportService.GetAirTransportById(id);
            AirTransportDetailsViewModel model = new AirTransportDetailsViewModel()
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
                Name = item.Name,
                Functionality = item.Functionality,
                ResultValue = item.ResultValue,
            };
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] AirTransportAddViewModel model)
        {
            var created = _airTransportService.CreateAirTransport(model.ManifactureYear, model.SecurityEquipmenPossession, model.TechnicalServiceability, model.PreviousAccidents,
                model.DistanceTraveled, model.Height, model.Weight, model.Width, model.RegisteredCountry, model.RegisteredRegion,
                model.RegisteredCity, model.Functionality, model.Name, User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (created)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            var entity = _airTransportService.GetAirTransportById(id);
            if (entity == null)
            {
                return NotFound();
            }
            AirTransportEditViewModel model = new AirTransportEditViewModel()
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
                Name = entity.Name,
                Functionality = entity.Functionality,
                ResultValue = entity.ResultValue,
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, AirTransportEditViewModel model)
        {
            var updated = _airTransportService.UpdateAirTransport(id, model.ManifactureYear, model.SecurityEquipmenPossession, model.TechnicalServiceability, model.PreviousAccidents,
                model.DistanceTraveled, model.Height, model.Weight, model.Width, model.RegisteredCountry, model.RegisteredRegion,
                model.RegisteredCity, model.Functionality, model.Name);
            if (updated)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
        public ActionResult Delete(int id)
        {
            var item = _airTransportService.GetAirTransportById(id);
            AirTransportDetailsViewModel model = new AirTransportDetailsViewModel()
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
                Name = item.Name,
                Functionality = item.Functionality,
                ResultValue = item.ResultValue,
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _airTransportService.Remove(id);
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
