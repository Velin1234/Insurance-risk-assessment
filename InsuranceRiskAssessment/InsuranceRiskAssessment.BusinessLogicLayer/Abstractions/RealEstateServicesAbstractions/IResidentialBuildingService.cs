using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices
{
    public interface IResidentialBuildingService
    {
        bool CreateResidentialBuilding(string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string floor);
        bool UpdateResidentialBuilding(int residentialBuildingId, string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string floor);
        List<ResidentialBuilding> GetResidentialBuildings();
        ResidentialBuilding GetResidentialBuildingById(int residentialBuildingId);
        bool Remove(int businessEnterpriseId);
    }
}
