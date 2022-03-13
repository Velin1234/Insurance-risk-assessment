using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices
{
    public interface IVehicleByLandService
    {
        bool CreateVehicleByLand(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string fuelType, bool parktronic, string mostCommonRoutes, string registerNumber);
        bool UpdateVehicleByLand(int vehicleByLandId, DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string fuelType, bool parktronic, string mostCommonRoutes, string registerNumber);
        List<VehicleByLand> GetVehiclesByLand();
        VehicleByLand GetVehicleByLandById(int vehicleByLandId);
        bool Remove(int vehicleByLandId);
    }
}
