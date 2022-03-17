using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InsuranceRiskAssessment.Web.Controllers.RealEstateControllers
{
    public class ResidentialBuildingsController : Controller
    {
        private readonly IResidentialBuildingService _residentialBuildingService;

        public ResidentialBuildingsController(IResidentialBuildingService residentialBuildingService)
        {
            _residentialBuildingService = residentialBuildingService;
        }

        // GET: ResidentialBuildings
        public ActionResult Index()
        {
            List<ResidentialBuildingViewModel> residentialBuildings = _residentialBuildingService.GetResidentialBuildings()
                .Select(item => new ResidentialBuildingViewModel()
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
                    Floor = item.Floor,
                    ResultValue = item.ResultValue

                }).ToList();

            return View(residentialBuildings);
        }

        // GET: ResidentialBuildings/Details/5
        public ActionResult Details(int id)
        {
            var item = _residentialBuildingService.GetResidentialBuildingById(id);

            ResidentialBuildingDetailsViewModel model = new ResidentialBuildingDetailsViewModel()
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
                Floor = item.Floor,
                ResultValue = item.ResultValue
            };

            return View(model);
        }

        // GET: ResidentialBuildings/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResidentialBuildings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] ResidentialBuildingAddViewModel model)
        {
            var created = _residentialBuildingService.CreateResidentialBuilding(model.Country, model.Region,
                model.City, model.Address, model.FireExtinguishers, model.EmergencyExit, model.SquareFeet, model.AlarmSystem,
                model.GasBottles, model.Floor);

            if (created)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: ResidentialBuildings/Edit/5
        public ActionResult Edit(int id)
        {
            var entity = _residentialBuildingService.GetResidentialBuildingById(id);
            if (entity == null)
            {
                return NotFound();
            }

            ResidentialBuildingEditViewModel model = new ResidentialBuildingEditViewModel()
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
                Floor = entity.Floor,
                ResultValue = entity.ResultValue
            };

            return View(model);
        }

        // POST: ResidentialBuildings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ResidentialBuildingEditViewModel model)
        {
            var updated = _residentialBuildingService.UpdateResidentialBuilding(id, model.Country, model.Region,
                model.City, model.Address, model.FireExtinguishers, model.EmergencyExit, model.SquareFeet, model.AlarmSystem,
                model.GasBottles, model.Floor);

            if (updated)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: ResidentialBuildings/Delete/5
        public ActionResult Delete(int id)
        {
            var item = _residentialBuildingService.GetResidentialBuildingById(id);
            ResidentialBuildingDetailsViewModel model = new ResidentialBuildingDetailsViewModel()
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
                Floor = item.Floor,
                ResultValue = item.ResultValue
            };
            return View(model);
        }

        // POST: ResidentialBuildings/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _residentialBuildingService.Remove(id);
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
