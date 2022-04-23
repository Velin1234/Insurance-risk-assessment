using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.AirTransport
{
    public class AirTransportEditViewModel : MovablePropertiesViewModel
    {
        [Required]
        [DisplayName("Функционалност:")]
        public string Functionality { get; set; }
        [Required]
        [DisplayName("Име:")]
        public string Name { get; set; }
    }
}
