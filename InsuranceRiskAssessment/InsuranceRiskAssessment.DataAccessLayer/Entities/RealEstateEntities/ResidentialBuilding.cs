using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities
{
    public class ResidentialBuilding : RealEstateProperty
    {
        public string Floor { get; set; }
    }
}
