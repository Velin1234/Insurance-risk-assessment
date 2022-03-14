using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.BusinessEnterprise;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace InsuranceRiskAssessment.Web.Controllers.RealEstateControllers
{
    public class BusinessEnterprisesController : Controller
    {
        private readonly IBusinessEnterpriseService _businessEnterpriseService;

        public BusinessEnterprisesController(IBusinessEnterpriseService businessEnterpriseService)
        {
            _businessEnterpriseService = businessEnterpriseService;
        }

        // GET: BusinessEnterprises
        public ActionResult Index()
        {
            List<BusinessEnterpriseViewModel> businessEnterprises = _businessEnterpriseService.GetBusinessEnterprises()
                .Select(item => new BusinessEnterpriseViewModel()
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
                    PurposeOfTheEnterprise = item.PurposeOfTheEnterprise,
                    ResultValue = item.ResultValue

                }).ToList();

            return View(businessEnterprises);
        }

        // GET: BusinessEnterprises/Details/5
        public ActionResult Details(int id)
        {
            var item = _businessEnterpriseService.GetBusinessEnterpriseById(id);

            BusinessEnterpriseDetailsViewModel model = new BusinessEnterpriseDetailsViewModel()
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
                PurposeOfTheEnterprise = item.PurposeOfTheEnterprise,
                ResultValue = item.ResultValue
            };

            return View(model);
        }

        // GET: BusinessEnterprises/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BusinessEnterprises/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] BusinessEnterpriseAddViewModel model)
        {
            var created = _businessEnterpriseService.CreateBusinessEnterprise(model.Country, model.Region,
                model.City, model.Address, model.FireExtinguishers, model.EmergencyExit, model.SquareFeet, model.AlarmSystem,
                model.GasBottles, model.PurposeOfTheEnterprise);

            if (created)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: BusinessEnterprises/Edit/5
        public ActionResult Edit(int id)
        {
            var entity = _businessEnterpriseService.GetBusinessEnterpriseById(id);
            if (entity == null)
            {
                return NotFound();
            }

            BusinessEnterpriseEditViewModel model = new BusinessEnterpriseEditViewModel()
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
                PurposeOfTheEnterprise = entity.PurposeOfTheEnterprise,
                ResultValue = entity.ResultValue
            };

            return View(model);
        }

        // POST: BusinessEnterprises/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BusinessEnterpriseEditViewModel model)
        {
            var updated = _businessEnterpriseService.UpdateBusinessEnterprise(id, model.Country, model.Region,
                model.City, model.Address, model.FireExtinguishers, model.EmergencyExit, model.SquareFeet, model.AlarmSystem,
                model.GasBottles, model.PurposeOfTheEnterprise);

            if (updated)
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        // GET: BusinessEnterprises/Delete/5
        public ActionResult Delete(int id)
        {
            var item = _businessEnterpriseService.GetBusinessEnterpriseById(id);
            BusinessEnterpriseDetailsViewModel model = new BusinessEnterpriseDetailsViewModel()
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
                PurposeOfTheEnterprise = item.PurposeOfTheEnterprise,
                ResultValue = item.ResultValue
            };
            return View(model);
        }

        // POST: BusinessEnterprises/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var deleted = _businessEnterpriseService.Remove(id);
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
