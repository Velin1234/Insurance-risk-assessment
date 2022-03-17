using InsuranceRiskAssessment.DataAccessLayer.Data;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
{
    public class VehicleByLand : MovableProperty
    {
        public string FuelType { get; set; }
        public bool Parktronic { get; set; }
        public string MostCommonRoutes { get; set; }
        public string RegisterNumber { get; set; }
        public virtual InsuranceBrokerUser InsuranceBroker { get; set; }

    }
}
