using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.RealEstateServicess
{
    public class VillaBuildingService : IVillaBuildingService
    {
        public readonly IRepository<VillaBuilding> _villaBuildingRepository;
        public VillaBuildingService(IRepository<VillaBuilding> villaBuildingRepository)
        {
            _villaBuildingRepository = villaBuildingRepository;
        }
        public bool CreateVillaBuilding(string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles)
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
                GasBottles = gasBottles
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

        public bool UpdateVillaBuilding(int villaBuildingId, string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles)
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

            return _villaBuildingRepository.Update(villaBuilding);
        }
    }
}
