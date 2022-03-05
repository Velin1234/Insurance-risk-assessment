using InsuranceRiskAssessment.DataAccessLayer.Entities;
using InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities;
using InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.DataAccessLayer.Data
{
    public class InsuranceBrokerUser : IdentityUser
    {
        public virtual ICollection<AirTransport> CheckedAirTransport { get; set; }
        public virtual ICollection<SeaTransport> CheckedSeaTransport { get; set; }
        public virtual ICollection<VehicleByLand> CheckedVehicleByLand { get; set; }

        public virtual ICollection<BusinessEnterprise> CheckedBusinessEnterprise { get; set; }
        public virtual ICollection<CommercialProperty> CheckedCommercialProperty { get; set; }
        public virtual ICollection<ResidentialBuilding> CheckedResidentialBuildings { get; set; }
        public virtual ICollection<VillaBuilding> CheckedVillaBuildings { get; set; }

    }
}
