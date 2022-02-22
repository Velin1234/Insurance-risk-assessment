using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities
{
    public class BusinessEnterprise : RealEstateProperty
    {
        public string PurposeOfTheEnterprise { get; set; }
    }
}
