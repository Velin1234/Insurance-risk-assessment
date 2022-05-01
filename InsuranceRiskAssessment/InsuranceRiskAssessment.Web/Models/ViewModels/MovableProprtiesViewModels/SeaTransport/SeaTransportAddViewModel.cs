using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.SeaTransport
{
    public class SeaTransportAddViewModel : MovablePropertiesViewModel
    {
        [Required]
        [DisplayName("Име:")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Маршрута минава ли през пиратска активност")]
        public bool DoesRoutePassesPirateZones { get; set; }
        [Required]
        [DisplayName("Функционалност:")]
        public string Functionality { get; set; }
        [Required]
        [DisplayName("Начин на задвижване:")]
        public string TypeOfMovability { get; set; }
    }
}
