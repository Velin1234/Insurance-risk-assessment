using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.AirTransport
{
    public class AirTransportEditViewModel : MovablePropertiesViewModel
    {
        [Required]
        [DisplayName("Климатична зона")]
        public string ClimatZone { get; set; }
        [Required]
        [DisplayName("Функционалност")]
        public string Functionality { get; set; }
    }
}
