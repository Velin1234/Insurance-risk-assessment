using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices
{
    public interface IAirTransportService
    {
        bool CreateAirTransport(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string climatZone, string functionality);
        bool UpdateAirTransport(int airTransportId, DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string climatZone, string functionality);
        List<AirTransport> GetAirTransports();
        AirTransport GetAirTransportById(int airTransportId);
        bool Remove(int airTransportId);
    }
}
