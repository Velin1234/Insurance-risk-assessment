using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices
{
    public interface ICommercialPropertyService
    {
        bool CreateCommercialProperty(string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles);
        bool UpdateCommercialProperty(int commercialPropertyId, string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles);
        List<CommercialProperty> GetCommercialProperty();
        CommercialProperty GetCommercialPropertyById(int commercialPropertyId);
        bool Remove(int commercialPropertyId);
    }
}
