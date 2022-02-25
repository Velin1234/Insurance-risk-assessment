using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.MovablePropertyServices
{
    public class VehicleByLandService : IVehicleByLandService
    {
        public readonly IRepository<VehicleByLand> _vehicleByLandRepository;
        public VehicleByLandService(IRepository<VehicleByLand> vehicleByLandRepository)
        {
            _vehicleByLandRepository = vehicleByLandRepository;
        }

        public bool CreateVehicleByLand(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability, int distanceTraveled, double height,
            double weight, double width, string registeredCountry, string registeredRegion, string registeredCity, string fuelType, bool parktronic, string mostCommonRoutes, string registerNumber)
        {
            var vehicleByLand = new VehicleByLand()
            {
                ManifactureYear = manifactureYear,
                SecurityEquipmenPossession = securityEquipmenPossession,
                TechnicalServiceability = technicalServiceability,
                DistanceTraveled = distanceTraveled,
                Height = height,
                Weight = weight,
                Width = width,
                RegisteredCountry = registeredCountry,
                RegisteredRegion = registeredRegion,
                RegisteredCity = registeredCity,
                FuelType = fuelType,
                Parktronic = parktronic,
                MostCommonRoutes = mostCommonRoutes,
                RegisterNumber = registerNumber
            };
            return _vehicleByLandRepository.Create(vehicleByLand);
        }

        public VehicleByLand GetVehicleByLandById(int vehicleByLandId)
        {
            return _vehicleByLandRepository.GetById(vehicleByLandId);
        }

        public List<VehicleByLand> GetVehiclesByLand()
        {
            return _vehicleByLandRepository.GetAll();
        }

        public bool Remove(int vehicleByLandId)
        {
            return _vehicleByLandRepository.RemoveById(vehicleByLandId);
        }

        public bool UpdateVehicleByLand(int vehicleByLandId, DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability, int distanceTraveled, double height,
            double weight, double width, string registeredCountry, string registeredRegion, string registeredCity, string fuelType, bool parktronic, string mostCommonRoutes, string registerNumber)
        {
            var vehicleByLand = GetVehicleByLandById(vehicleByLandId);
            if (vehicleByLand == default(VehicleByLand))
            {
                return false;
            }

            vehicleByLand.ManifactureYear = manifactureYear;
            vehicleByLand.SecurityEquipmenPossession = securityEquipmenPossession;
            vehicleByLand.TechnicalServiceability = technicalServiceability;
            vehicleByLand.DistanceTraveled = distanceTraveled;
            vehicleByLand.Height = height;
            vehicleByLand.Weight = weight;
            vehicleByLand.Width = width;
            vehicleByLand.RegisteredCountry = registeredCountry;
            vehicleByLand.RegisteredRegion = registeredRegion;
            vehicleByLand.RegisteredCity = registeredCity;
            vehicleByLand.Parktronic = parktronic;
            vehicleByLand.FuelType = fuelType;
            vehicleByLand.MostCommonRoutes = mostCommonRoutes;
            vehicleByLand.RegisterNumber = registerNumber;

            return _vehicleByLandRepository.Update(vehicleByLand);
        }
    }
}
