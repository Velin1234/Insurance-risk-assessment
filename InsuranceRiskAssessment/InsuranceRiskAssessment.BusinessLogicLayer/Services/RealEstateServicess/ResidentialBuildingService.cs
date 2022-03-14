using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.RealEstateServicess
{
    public class ResidentialBuildingService : IResidentialBuildingService
    {
        public readonly IRepository<ResidentialBuilding> _residentialBuildingRepository;
        public ResidentialBuildingService(IRepository<ResidentialBuilding> residentialBuildingRepository)
        {
            _residentialBuildingRepository = residentialBuildingRepository;
        }

        public bool CreateResidentialBuilding(string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string floor)
        {
            var residentialBuilding = new ResidentialBuilding()
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
                Floor = floor
            };
            return _residentialBuildingRepository.Create(residentialBuilding);
        }

        public ResidentialBuilding GetResidentialBuildingById(int residentialBuildingId)
        {
            return _residentialBuildingRepository.GetById(residentialBuildingId);
        }

        public List<ResidentialBuilding> GetResidentialBuildings()
        {
            return _residentialBuildingRepository.GetAll();
        }

        public bool Remove(int residentialBuildingId)
        {
            return _residentialBuildingRepository.RemoveById(residentialBuildingId);
        }

        public bool UpdateResidentialBuilding(int residentialBuildingId, string country, string region, string city, string address, bool fireExtinguishers, bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string floor)
        {
            var residentialBuilding = GetResidentialBuildingById(residentialBuildingId);
            if (residentialBuilding == default(ResidentialBuilding))
            {
                return false;
            }

            residentialBuilding.Country = country;
            residentialBuilding.Region = region;
            residentialBuilding.City = city;
            residentialBuilding.Address = address;
            residentialBuilding.FireExtinguishers = fireExtinguishers;
            residentialBuilding.EmergencyExit = emergencyExit;
            residentialBuilding.SquareFeet = squareFeet;
            residentialBuilding.AlarmSystem = alarmSystem;
            residentialBuilding.GasBottles = gasBottles;
            residentialBuilding.Floor = floor;

            return _residentialBuildingRepository.Update(residentialBuilding);
        }
    }
}
