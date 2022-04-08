using System.ComponentModel;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.AirTransport
{
    public class AirTransportViewModel : MovablePropertiesViewModel
    {
        public string Name { get; set; }
        [DisplayName("Функционалност")]
        public string Functionality { get; set; }
        
    }
}
