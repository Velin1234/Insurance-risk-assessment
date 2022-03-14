using InsuranceRiskAssessment.DataAccessLayer.Data;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities
{
    public class ResidentialBuilding : RealEstateProperty
    {
        public string Floor { get; set; }
        public virtual InsuranceBrokerUser InsuranceBroker { get; set; }

    }
}
