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
        public bool CreateBusinessEnterprise(string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise)
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
                PurposeOfTheEnterprise = purposeOfTheEnterprise
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
            bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise)
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

            return _businessEnterpriseRepository.Update(businessEnterprise);
        }
    }
}
