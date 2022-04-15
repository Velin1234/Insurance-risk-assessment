using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices
{
    public interface IResidentialBuildingService
    {
        bool CreateResidentialBuilding(string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string floor, bool previousIncidents);
        bool UpdateResidentialBuilding(int residentialBuildingId, string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string floor, bool previousIncidents);
        List<ResidentialBuilding> GetResidentialBuildings();
        ResidentialBuilding GetResidentialBuildingById(int residentialBuildingId);
        bool Remove(int businessEnterpriseId);
    }
}
