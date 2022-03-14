using System.ComponentModel;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.AirTransport
{
    public class AirTransportViewModel : MovablePropertiesViewModel
    {
        [DisplayName("Климатична зона")]
        public string ClimatZone { get; set; }
        [DisplayName("Функционалност")]
        public string Functionality { get; set; }
    }
}
