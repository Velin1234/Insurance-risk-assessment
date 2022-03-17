using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System.Collections.Generic;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices
{
    public interface IBusinessEnterpriseService
    {
        bool CreateBusinessEnterprise(string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise);
        bool UpdateBusinessEnterprise(int businessEnterpriseId, string country, string region, string city, string address, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise);
        List<BusinessEnterprise> GetBusinessEnterprises();
        BusinessEnterprise GetBusinessEnterpriseById(int businessEnterpriseId);
        bool Remove(int businessEnterpriseId);
    }
}
