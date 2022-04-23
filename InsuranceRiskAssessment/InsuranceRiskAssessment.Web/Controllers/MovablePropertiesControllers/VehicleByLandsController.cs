using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.VehicleByLand;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InsuranceRiskAssessment.Web.Controllers.MovablePropertiesControllers
{
    public class VehicleByLandsController : Controller
    {
        private readonly IVehicleByLandService _vehicleByLandService;

        public VehicleByLandsController(IVehicleByLandService vehicleByLandService)
        {
            _vehicleByLandService = vehicleByLandService;
        }

        public ActionResult Index()
        {
            List<VehicleByLandViewModel> vehiclesByLand = _vehicleByLandService.GetVehiclesByLand()
              .Select(item => new VehicleByLandViewModel()
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
                  FuelType = item.FuelType,
                  RegisterNumber = item.RegisterNumber,
                  Parktronic = item.Parktronic,
                  MostCommonRoutes = item.MostCommonRoutes,
                  ResultValue = item.ResultValue

              }).ToList();

            return View(vehiclesByLand);

        }

        public ActionResult Details(int id)
        {
            var item = _vehicleByLandService.GetVehicleByLandById(id);
            VehicleByLandDetailsViewModel model = new VehicleByLandDetailsViewModel()
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
                FuelType = item.FuelType,
                RegisterNumber = item.RegisterNumber,
                Parktronic = item.Parktronic,
                MostCommonRoutes = item.MostCommonRoutes,
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
        public ActionResult Create([FromForm] VehicleByLandAddViewModel model)
        {
            var created = _vehicleByLandService.CreateVehicleByLand(model.ManifactureYear, model.SecurityEquipmenPossession, model.TechnicalServiceability,
                model.DistanceTraveled, model.Height, model.Weight, model.Width, model.RegisteredCountry, model.RegisteredRegion,
                model.RegisteredCity, model.FuelType, model.Parktronic, model.MostCommonRoutes, model.RegisterNumber,model.PreviousAccidents);

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
            var entity = _vehicleByLandService.GetVehicleByLandById(id);
            if (entity == null)
            {
                return NotFound();
            }

            VehicleByLandEditViewModel model = new VehicleByLandEditViewModel()
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
                FuelType = entity.FuelType,
                RegisterNumber = entity.RegisterNumber,
                Parktronic = entity.Parktronic,
                MostCommonRoutes = entity.MostCommonRoutes,
                ResultValue = entity.ResultValue
            };
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VehicleByLandEditViewModel model)
        {
            var updated = _vehicleByLandService.UpdateVehicleByLand(id, model.ManifactureYear, model.SecurityEquipmenPossession, model.TechnicalServiceability,
                model.DistanceTraveled, model.Height, model.Weight, model.Width, model.RegisteredCountry, model.RegisteredRegion,
                model.RegisteredCity, model.FuelType, model.Parktronic, model.MostCommonRoutes, model.RegisterNumber,model.PreviousAccidents);

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
            var item = _vehicleByLandService.GetVehicleByLandById(id);
            VehicleByLandDetailsViewModel model = new VehicleByLandDetailsViewModel()
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
                FuelType = item.FuelType,
                RegisterNumber = item.RegisterNumber,
                Parktronic = item.Parktronic,
                MostCommonRoutes = item.MostCommonRoutes,
                ResultValue = item.ResultValue
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var deleted = _vehicleByLandService.Remove(id);
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
