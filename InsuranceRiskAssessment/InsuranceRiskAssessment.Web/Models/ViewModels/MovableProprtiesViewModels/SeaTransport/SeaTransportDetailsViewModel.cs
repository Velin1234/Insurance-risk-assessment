namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.SeaTransport
{
    public class SeaTransportDetailsViewModel : MovablePropertiesViewModel
    {
        public string Name { get; set; }
        public bool DoesRoutePassesPirateZones { get; set; }
        public string Functionality { get; set; }
        public string TypeOfMovability { get; set; }
    }
}
