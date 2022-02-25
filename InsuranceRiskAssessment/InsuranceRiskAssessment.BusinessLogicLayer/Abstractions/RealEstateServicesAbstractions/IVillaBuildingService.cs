using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices
{
    public interface IVillaBuildingService
    {
        bool CreateVillaBuilding(string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles);
        bool UpdateVillaBuilding(int villaBuildingId, string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles);
        List<VillaBuilding> GetVillaBuildings();
        VillaBuilding GetVillaBuildingById(int villaBuildingId);
        bool Remove(int villaBuildingId);
    }
}
