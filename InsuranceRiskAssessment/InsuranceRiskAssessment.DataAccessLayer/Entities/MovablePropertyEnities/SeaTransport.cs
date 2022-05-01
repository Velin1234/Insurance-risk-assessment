namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
{
    public class SeaTransport : MovableProperty
    {
        public string Name { get; set; }
        public bool DoesRoutePassesPirateZones { get; set; }
        public string Functionality { get; set; }
        public string TypeOfMovability { get; set; }
    }
}
