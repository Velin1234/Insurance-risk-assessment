using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.RealEstateServicess
{
    public class CommercialProprtyService : ICommercialPropertyService
    {
        private readonly IRepository<CommercialProperty> _commercialPropertyRepository;
        public CommercialProprtyService(IRepository<CommercialProperty> commercialPropertyRepository)
        {
            _commercialPropertyRepository = commercialPropertyRepository;
        }
        public bool CreateCommercialProperty(string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, bool previousIncidents)
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
                GasBottles = gasBottles,
                PreviousAccidents = previousIncidents,
                ModifiedAt = System.DateTime.Now,
                ResultValue = GetResultValue(fireExtinguishers, emergencyExit, alarmSystem, gasBottles, previousIncidents)
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

        public bool UpdateCommercialProperty(int commercialPropertyId, string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles,bool previousIncidents)
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
            commercialProperty.PreviousAccidents = previousIncidents;
            commercialProperty.ModifiedAt = System.DateTime.Now;
            commercialProperty.ResultValue = GetResultValue(fireExtinguishers, emergencyExit, alarmSystem, gasBottles, previousIncidents);

            return _commercialPropertyRepository.Update(commercialProperty);
        }
        private int GetResultValue(bool fireExtinguishers, bool emergencyExit, bool alarmSystem, bool gasBottles, bool previousIncidents)
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
                initialResultValue -= 35;
            }
            if (!alarmSystem)
            {
                initialResultValue -= 15;
            }
            if (gasBottles)
            {
                initialResultValue -= 20;
            }

            return initialResultValue;
        }
    }
}
