using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices
{
    public interface ICommercialPropertyService
    {
        bool CreateCommercialProperty(string country, string region, string city, string adress, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles);
        bool UpdateCommercialProperty(int commercialPropertyId, string country, string region, string city, string adress, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles);
        List<CommercialProperty> GetCommercialProperty();
        CommercialProperty GetCommercialPropertyById(int commercialPropertyId);
        bool Remove(int commercialPropertyId);
    }
}
