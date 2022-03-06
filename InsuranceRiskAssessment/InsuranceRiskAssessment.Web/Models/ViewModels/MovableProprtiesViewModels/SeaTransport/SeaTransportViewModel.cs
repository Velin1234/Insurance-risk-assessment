namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.SeaTransport
{
    public class SeaTransportViewModel : MovablePropertiesViewModel
    {
        public string ClimatZone { get; set; }
        public bool DoesRoutePassesPirateZones { get; set; }
        public string Functionality { get; set; }
        public string TypeOfMovability { get; set; }
    }
}
