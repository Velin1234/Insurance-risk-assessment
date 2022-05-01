using InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices;
using InsuranceRiskAssessment.DataAccessLayer.Abstractions;
using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Services.MovablePropertyServices
{
    public class VehicleByLandService : IVehicleByLandService
    {
        private readonly IRepository<VehicleByLand> _vehicleByLandRepository;
        public VehicleByLandService(IRepository<VehicleByLand> vehicleByLandRepository)
        {
            _vehicleByLandRepository = vehicleByLandRepository;
        }
        public bool CreateVehicleByLand(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability, int distanceTraveled, double height,
            double weight, double width, string registeredCountry, string registeredRegion, string registeredCity, string fuelType, bool parktronic, string mostCommonRoutes, string registerNumber, bool previousIncidents, string brokerId)
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
                ModifiedAt = DateTime.Now,
                RegisteredCountry = registeredCountry,
                RegisteredRegion = registeredRegion,
                RegisteredCity = registeredCity,
                FuelType = fuelType,
                Parktronic = parktronic,
                MostCommonRoutes = mostCommonRoutes,
                PreviousAccidents = previousIncidents,
                RegisterNumber = registerNumber,
                ResultValue = GetResultValue(manifactureYear, securityEquipmenPossession, technicalServiceability,
            previousIncidents, distanceTraveled, fuelType, parktronic, mostCommonRoutes),
                InsuranceBroker = brokerId
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
            double weight, double width, string registeredCountry, string registeredRegion, string registeredCity, string fuelType, bool parktronic, string mostCommonRoutes, string registerNumber,
            bool previousIncidents)
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
            vehicleByLand.ModifiedAt = DateTime.Now;
            vehicleByLand.MostCommonRoutes = mostCommonRoutes;
            vehicleByLand.RegisterNumber = registerNumber;
            vehicleByLand.PreviousAccidents = previousIncidents;
            vehicleByLand.ResultValue = GetResultValue(manifactureYear, securityEquipmenPossession, technicalServiceability,
            previousIncidents, distanceTraveled, fuelType, parktronic, mostCommonRoutes);
            return _vehicleByLandRepository.Update(vehicleByLand);
        }
        private int GetResultValue(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            bool previousIncidents, int distanceTraveled, string fuelType, bool parktronic, string mostCommonRoutes)
        {
            int initialResultValue = 100;
            int currentYear = DateTime.Now.Year;
            int manifacture_year = manifactureYear.Year;
            int yearDifference = currentYear - manifacture_year;

            if (previousIncidents)
            {
                initialResultValue -= 5;
            }
            if (yearDifference >= 5 && yearDifference <= 10)
            {
                initialResultValue -= 5;
            }
            else if (yearDifference > 10 && yearDifference <= 15)
            {
                initialResultValue -= 10;
            }
            else if (yearDifference > 15)
            {
                initialResultValue -= 15;
            }
            if (!securityEquipmenPossession)
            {
                initialResultValue -= 15;
            }
            if (!technicalServiceability)
            {
                initialResultValue -= 15;
            }
            if (distanceTraveled >= 100000 && distanceTraveled < 200000)
            {
                initialResultValue -= 5;
            }
            else if (distanceTraveled >= 200000)
            {
                initialResultValue -= 10;
            }

            if (!parktronic)
            {
                initialResultValue -= 15;
            }

            switch (fuelType)
            {
                case "Бензин":
                    initialResultValue -= 10;
                    break;
                case "Дизел":
                    initialResultValue -= 5;
                    break;
                case "Бензин + пропан":
                    initialResultValue -= 15;
                    break;
                case "Електричество":
                    initialResultValue -= 5;
                    break;
            }

            switch (mostCommonRoutes)
            {
                case "Градски":
                    initialResultValue -= 10;
                    break;
                case "Междуградски":
                    initialResultValue -= 5;
                    break;
            }

            return initialResultValue;
        }
    }
}
