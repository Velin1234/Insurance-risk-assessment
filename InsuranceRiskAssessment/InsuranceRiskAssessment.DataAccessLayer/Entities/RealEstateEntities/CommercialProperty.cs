using InsuranceRiskAssessment.DataAccessLayer.Data;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities
{
    public class CommercialProperty : RealEstateProperty
    {
        public virtual InsuranceBrokerUser InsuranceBroker { get; set; }

    }
}
