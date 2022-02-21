using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.BusinessLogicLayer.Abstractions.RealEstateServices
{
    public interface IBusinessEnterpriseService
    {
        bool CreateBusinessEnterprise(string country, string region, string city, string adress, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise);
        bool UpdateBusinessEnterprise(int businessEnterpriseId, string country, string region, string city, string adress, bool fireExtinguishers,
            bool emergencyExit, double squareFeet, bool alarmSystem, bool gasBottles, string purposeOfTheEnterprise);
        List<BusinessEnterprise> GetBusinessEnterprises();
        BusinessEnterprise GetBusinessEnterpriseById(int businessEnterpriseId);
        bool Remove(int businessEnterpriseId);
    }
}
