using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.SeaTransport;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace InsuranceRiskAssessment.Web.Controllers.MovablePropertiesControllers
{
    public class SeaTransportsController : Controller
    {
        private readonly ISeaTransportService _seaTransportService;

        public SeaTransportsController(ISeaTransportService seaTransportService)
        {
            _seaTransportService = seaTransportService;
        }

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
                   Name = item.Name,
                   Functionality = item.Functionality,
                   TypeOfMovability = item.TypeOfMovability,
                   DoesRoutePassesPirateZones = item.DoesRoutePassesPirateZones,
                   ResultValue = item.ResultValue,
                   InsuranceBroker = item.InsuranceBroker

               }).ToList();

            return View(seaTransports);
        }

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
                Name = item.Name,
                Functionality = item.Functionality,
                TypeOfMovability = item.TypeOfMovability,
                DoesRoutePassesPirateZones = item.DoesRoutePassesPirateZones,
                ResultValue = item.ResultValue
            };
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] SeaTransportAddViewModel model)
        {
            var created = _seaTransportService.CreateSeaTransport(model.ManifactureYear, model.SecurityEquipmenPossession, model.TechnicalServiceability,
                model.DistanceTraveled, model.Height, model.Weight, model.Width, model.RegisteredCountry, model.RegisteredRegion,
                model.RegisteredCity, model.DoesRoutePassesPirateZones, model.Functionality, model.TypeOfMovability,model.Name,model.PreviousAccidents, User.FindFirstValue(ClaimTypes.NameIdentifier));

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
            var entity = _seaTransportService.GetSeaTransportById(id);
            if (entity == null)
            {
                return NotFound();
            }

            SeaTransportEditViewModel model = new SeaTransportEditViewModel()
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
                TypeOfMovability = entity.TypeOfMovability,
                DoesRoutePassesPirateZones = entity.DoesRoutePassesPirateZones,
                ResultValue = entity.ResultValue
            };

            return View(model);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, SeaTransportEditViewModel model)
        {
            var updated = _seaTransportService.UpdateSeaTransport(id, model.ManifactureYear, model.SecurityEquipmenPossession, model.TechnicalServiceability,
                model.DistanceTraveled, model.Height, model.Weight, model.Width, model.RegisteredCountry, model.RegisteredRegion,
                model.RegisteredCity, model.DoesRoutePassesPirateZones, model.Functionality, model.TypeOfMovability, model.Name, model.PreviousAccidents);

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
                Name = item.Name,
                Functionality = item.Functionality,
                TypeOfMovability = item.TypeOfMovability,
                DoesRoutePassesPirateZones = item.DoesRoutePassesPirateZones,
                ResultValue = item.ResultValue
            };
            return View(model);
        }

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
