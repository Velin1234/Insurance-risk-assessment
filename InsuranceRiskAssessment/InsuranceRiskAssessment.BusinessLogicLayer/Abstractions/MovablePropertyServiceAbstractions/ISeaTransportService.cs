using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.MovablePropertyServices
{
    public interface ISeaTransportService
    {
        bool CreateSeaTransport(DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string climatZone, bool doesRoutePassesPirateZones, string functionality, string typeOfMovability);
        bool UpdateSeaTransport(int seaTransportId, DateTime manifactureYear, bool securityEquipmenPossession, bool technicalServiceability,
            int distanceTraveled, double height, double weight, double width, string registeredCountry, string registeredRegion,
            string registeredCity, string climatZone, bool doesRoutePassesPirateZones, string functionality, string typeOfMovability);
        List<SeaTransport> GetSeaTransports();
        SeaTransport GetSeaTransportById(int seaTransportId);
        bool Remove(int seaTransportId);
    }
}
