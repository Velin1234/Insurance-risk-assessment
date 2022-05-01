using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.RealEstateServicess
{
    public class BusinessEnterpriseService : IBusinessEnterpriseService
    {
        private readonly IRepository<BusinessEnterprise> _businessEnterpriseRepository;

        public BusinessEnterpriseService(IRepository<BusinessEnterprise> businessEnterpriseRepository)
        {
            _businessEnterpriseRepository = businessEnterpriseRepository;
        }
        public bool CreateBusinessEnterprise(string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise, bool previousIncidents, string brokerId)
        {
            var businessEnterprise = new BusinessEnterprise()
            {
                Country = country,
                Region = region,
                City = city,
                Address = address,
                FireExtinguishers = fireExtinguishers,
                EmergencyExit = emergencyExit,
                SquareFeet = squareFeet,
                AlarmSystem = alarmSystem,
                GasBottles = gasBottles,
                PurposeOfTheEnterprise = purposeOfTheEnterprise,
                ModifiedAt = System.DateTime.Now,
                PreviousAccidents = previousIncidents,
                ResultValue = GetResultValue(fireExtinguishers, emergencyExit, alarmSystem, gasBottles, purposeOfTheEnterprise, previousIncidents),
                InsuranceBroker = brokerId
            };
            return _businessEnterpriseRepository.Create(businessEnterprise);
        }

        public BusinessEnterprise GetBusinessEnterpriseById(int businessEnterpriseId)
        {
            return _businessEnterpriseRepository.GetById(businessEnterpriseId);
        }

        public List<BusinessEnterprise> GetBusinessEnterprises()
        {
            return _businessEnterpriseRepository.GetAll();
        }

        public bool Remove(int businessEnterpriseId)
        {
            return _businessEnterpriseRepository.RemoveById(businessEnterpriseId);
        }

        public bool UpdateBusinessEnterprise(int businessEnterpriseId, string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet,
            bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise, bool previousIncidents)
        {
            var businessEnterprise = GetBusinessEnterpriseById(businessEnterpriseId);
            if (businessEnterprise == default(BusinessEnterprise))
            {
                return false;
            }

            businessEnterprise.Country = country;
            businessEnterprise.Region = region;
            businessEnterprise.City = city;
            businessEnterprise.Address = address;
            businessEnterprise.FireExtinguishers = fireExtinguishers;
            businessEnterprise.EmergencyExit = emergencyExit;
            businessEnterprise.SquareFeet = squareFeet;
            businessEnterprise.AlarmSystem = alarmSystem;
            businessEnterprise.GasBottles = gasBottles;
            businessEnterprise.PurposeOfTheEnterprise = purposeOfTheEnterprise;
            businessEnterprise.PreviousAccidents = previousIncidents;
            businessEnterprise.ModifiedAt = System.DateTime.Now;
            businessEnterprise.ResultValue = GetResultValue(fireExtinguishers, emergencyExit, alarmSystem, gasBottles, purposeOfTheEnterprise, previousIncidents);
            return _businessEnterpriseRepository.Update(businessEnterprise);
        }
        private int GetResultValue(bool fireExtinguishers, bool emergencyExit, bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise, bool previousIncidents)
        {
            int initialResultValue = 100;
            if (previousIncidents)
            {
                initialResultValue -= 5;
            }
            if (!fireExtinguishers)
            {
                initialResultValue -= 25;
            }
            if (!emergencyExit)
            {
                initialResultValue -= 30;
            }
            if (!alarmSystem)
            {
                initialResultValue -= 10;
            }
            if (gasBottles)
            {
                initialResultValue -= 20;
            }
            switch (purposeOfTheEnterprise)
            {
                case "Производствена дейност":
                case "Преработваща дейност":
                    initialResultValue -= 10;
                    break;

            }

            return initialResultValue;
        }
    }
}

