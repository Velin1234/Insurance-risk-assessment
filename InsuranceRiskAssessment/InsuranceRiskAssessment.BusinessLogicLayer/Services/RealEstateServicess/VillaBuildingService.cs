using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.RealEstateServicess
{
    public class VillaBuildingService : IVillaBuildingService
    {
        private readonly IRepository<VillaBuilding> _villaBuildingRepository;
        public VillaBuildingService(IRepository<VillaBuilding> villaBuildingRepository)
        {
            _villaBuildingRepository = villaBuildingRepository;
        }
        public bool CreateVillaBuilding(string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, bool previousIncidents, string brokerId)
        {
            var villaBuilding = new VillaBuilding()
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
                ResultValue = GetResultValue(fireExtinguishers, emergencyExit, alarmSystem, gasBottles, previousIncidents),
                InsuranceBroker = brokerId
            };

            return _villaBuildingRepository.Create(villaBuilding);
        }
        public VillaBuilding GetVillaBuildingById(int villaBuildingId)
        {
            return _villaBuildingRepository.GetById(villaBuildingId);
        }

        public List<VillaBuilding> GetVillaBuildings()
        {
            return _villaBuildingRepository.GetAll();
        }

        public bool Remove(int villaBuildingId)
        {
            return _villaBuildingRepository.RemoveById(villaBuildingId);
        }

        public bool UpdateVillaBuilding(int villaBuildingId, string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, bool previousIncidents)
        {
            var villaBuilding = GetVillaBuildingById(villaBuildingId);
            if (villaBuilding == default(VillaBuilding))
            {
                return false;
            }

            villaBuilding.Country = country;
            villaBuilding.Region = region;
            villaBuilding.City = city;
            villaBuilding.Address = address;
            villaBuilding.FireExtinguishers = fireExtinguishers;
            villaBuilding.EmergencyExit = emergencyExit;
            villaBuilding.SquareFeet = squareFeet;
            villaBuilding.AlarmSystem = alarmSystem;
            villaBuilding.GasBottles = gasBottles;
            villaBuilding.PreviousAccidents = previousIncidents;
            villaBuilding.ResultValue = GetResultValue(fireExtinguishers, emergencyExit, alarmSystem, gasBottles, previousIncidents);
            villaBuilding.ModifiedAt = System.DateTime.Now;

            return _villaBuildingRepository.Update(villaBuilding);
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
