using InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels
{
    public class AirTransportAddViewModel : MovablePropertiesViewModel
    {
        [Required]
        [DisplayName("Климатична зона")]
        public string ClimatZone { get; set; }
        [Required]
        [DisplayName("Функционалност")]
        public string Functionality { get; set; }
    }
}
