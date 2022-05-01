using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.VillaBuilding;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace InsuranceRiskAssessment.Web.Controllers.RealEstateControllers
{
    public class VillaBuildingsController : Controller
    {
        private readonly IVillaBuildingService _villaBuildingService;
        public VillaBuildingsController(IVillaBuildingService villaBuildingService)
        {
            _villaBuildingService = villaBuildingService;
        }
        public ActionResult Index()
        {
            List<VillaBuildingViewModel> villaBuildings = _villaBuildingService.GetVillaBuildings()
                .Select(item => new VillaBuildingViewModel()
                {
                    Id = item.Id,
                    Country = item.Country,
                    Region = item.Region,
                    City = item.City,
                    Address = item.Address,
                    FireExtinguishers = item.FireExtinguishers,
                    EmergencyExit = item.EmergencyExit,
                    SquareFeet = item.SquareFeet,
                    AlarmSystem = item.AlarmSystem,
                    GasBottles = item.GasBottles,
                    CreatedAt = item.CreatedAt,
                    ModifiedAt = item.ModifiedAt,
                    PreviousAccidents = item.PreviousAccidents,
                    ResultValue = item.ResultValue,
                    InsuranceBroker = item.InsuranceBroker

                }).ToList();

            return View(villaBuildings);
        }
        public ActionResult Details(int id)
        {
            var item = _villaBuildingService.GetVillaBuildingById(id);
            VillaBuildingDetailsViewModel model = new VillaBuildingDetailsViewModel()
            {
                Id = item.Id,
                Country = item.Country,
                Region = item.Region,
                City = item.City,
                Address = item.Address,
                FireExtinguishers = item.FireExtinguishers,
                EmergencyExit = item.EmergencyExit,
                SquareFeet = item.SquareFeet,
                AlarmSystem = item.AlarmSystem,
                GasBottles = item.GasBottles,
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt,
                PreviousAccidents = item.PreviousAccidents,
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
        public ActionResult Create([FromForm] VillaBuildingAddViewModel model)
        {
            var created = _villaBuildingService.CreateVillaBuilding(model.Country, model.Region,
                model.City, model.Address, model.FireExtinguishers, model.EmergencyExit, model.SquareFeet, model.AlarmSystem,
                model.GasBottles,model.PreviousAccidents, User.FindFirstValue(ClaimTypes.NameIdentifier));
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
            var entity = _villaBuildingService.GetVillaBuildingById(id);
            if (entity == null)
            {
                return NotFound();
            }
            VillaBuildingEditViewModel model = new VillaBuildingEditViewModel()
            {
                Id = entity.Id,
                Country = entity.Country,
                Region = entity.Region,
                City = entity.City,
                Address = entity.Address,
                FireExtinguishers = entity.FireExtinguishers,
                EmergencyExit = entity.EmergencyExit,
                SquareFeet = entity.SquareFeet,
                AlarmSystem = entity.AlarmSystem,
                GasBottles = entity.GasBottles,
                CreatedAt = entity.CreatedAt,
                ModifiedAt = entity.ModifiedAt,
                PreviousAccidents = entity.PreviousAccidents,
                ResultValue = entity.ResultValue
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, VillaBuildingEditViewModel model)
        {
            var updated = _villaBuildingService.UpdateVillaBuilding(id, model.Country, model.Region,
                 model.City, model.Address, model.FireExtinguishers, model.EmergencyExit, model.SquareFeet, model.AlarmSystem,
                 model.GasBottles,model.PreviousAccidents);
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
            var item = _villaBuildingService.GetVillaBuildingById(id);
            VillaBuildingDetailsViewModel model = new VillaBuildingDetailsViewModel()
            {
                Id = item.Id,
                Country = item.Country,
                Region = item.Region,
                City = item.City,
                Address = item.Address,
                FireExtinguishers = item.FireExtinguishers,
                EmergencyExit = item.EmergencyExit,
                SquareFeet = item.SquareFeet,
                AlarmSystem = item.AlarmSystem,
                GasBottles = item.GasBottles,
                CreatedAt = item.CreatedAt,
                ModifiedAt = item.ModifiedAt,
                PreviousAccidents = item.PreviousAccidents,
                ResultValue = item.ResultValue
            };
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _villaBuildingService.Remove(id);
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
