using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.AirTransport
{
    public class AirTransportAddViewModel : MovablePropertiesViewModel
    {
        [Required]
        [DisplayName("Име:")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Функционалност:")]
        public string Functionality { get; set; }
        
    }
}
