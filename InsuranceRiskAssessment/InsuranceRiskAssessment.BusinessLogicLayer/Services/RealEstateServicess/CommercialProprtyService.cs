using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.RealEstateServicess
{
    public class CommercialProprtyService : ICommercialPropertyService
    {
        public readonly IRepository<CommercialProperty> _commercialPropertyRepository;
        public CommercialProprtyService(IRepository<CommercialProperty> commercialPropertyRepository)
        {
            _commercialPropertyRepository = commercialPropertyRepository;
        }
        public bool CreateCommercialProperty(string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles)
        {
            var commercialProperty = new CommercialProperty()
            {
                Country = country,
                Region = region,
                City = city,
                Address = address,
                FireExtinguishers = fireExtinguishers,
                EmergencyExit = emergencyExit,
                SquareFeet = squareFeet,
                AlarmSystem = alarmSystem,
                GasBottles = gasBottles
            };
            return _commercialPropertyRepository.Create(commercialProperty);
        }

        public List<CommercialProperty> GetCommercialProperty()
        {
            return _commercialPropertyRepository.GetAll();
        }

        public CommercialProperty GetCommercialPropertyById(int commercialPropertyId)
        {
            return _commercialPropertyRepository.GetById(commercialPropertyId);
        }

        public bool Remove(int commercialPropertyId)
        {
            return _commercialPropertyRepository.RemoveById(commercialPropertyId);
        }

        public bool UpdateCommercialProperty(int commercialPropertyId, string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles)
        {
            var commercialProperty = GetCommercialPropertyById(commercialPropertyId);
            if (commercialProperty == default(CommercialProperty))
            {
                return false;
            }

            commercialProperty.Country = country;
            commercialProperty.Region = region;
            commercialProperty.City = city;
            commercialProperty.Address = address;
            commercialProperty.FireExtinguishers = fireExtinguishers;
            commercialProperty.EmergencyExit = emergencyExit;
            commercialProperty.SquareFeet = squareFeet;
            commercialProperty.AlarmSystem = alarmSystem;
            commercialProperty.GasBottles = gasBottles;

            return _commercialPropertyRepository.Update(commercialProperty);
        }
    }
}
