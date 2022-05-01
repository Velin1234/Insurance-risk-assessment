using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices
{
    public interface ISeaTransportService
    {
        bool CreateSeaTransport(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, bool doesRoutePassesPirateZones, string functionality, string typeOfMovability, string name, bool previousIncidents, string brokerId);
        bool UpdateSeaTransport(int seaTransportId, DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, bool doesRoutePassesPirateZones, string functionality, string typeOfMovability, string name, bool previousIncidents);
        List<SeaTransport> GetSeaTransports();
        SeaTransport GetSeaTransportById(int seaTransportId);
        bool Remove(int seaTransportId);
    }
}
