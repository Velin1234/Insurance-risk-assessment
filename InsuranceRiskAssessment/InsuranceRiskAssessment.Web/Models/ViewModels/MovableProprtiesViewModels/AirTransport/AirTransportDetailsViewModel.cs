using System.ComponentModel;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.AirTransport
{
    public class AirTransportDetailsViewModel : MovablePropertiesViewModel
    {
        [DisplayName("Функционалност:")]
        public string Functionality { get; set; }
        [DisplayName("Име:")]
        public string Name { get; set; }
    }
}
