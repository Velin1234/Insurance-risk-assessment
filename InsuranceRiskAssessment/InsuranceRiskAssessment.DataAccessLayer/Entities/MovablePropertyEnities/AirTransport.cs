using InsuranceRiskAssessment.DataAccessLayer.Data;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
{
    public class AirTransport : MovableProperty
    {
        public string Name { get; set; }
        public string Functionality { get; set; }
        public virtual InsuranceBrokerUser InsuranceBroker { get; set; }

    }
}
