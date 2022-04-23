using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.VehicleByLand
{
    public class VehicleByLandEditViewModel : MovablePropertiesViewModel
    {
        [Required]
        [DisplayName("Вид гориво:")]
        public string FuelType { get; set; }
        [Required]
        [DisplayName("Парктроник")]
        public bool Parktronic { get; set; }
        [Required]
        [DisplayName("Най-чести маршрути:")]
        public string MostCommonRoutes { get; set; }
        [Required]
        [DisplayName("Рег. номер:")]
        public string RegisterNumber { get; set; }
    }
}
