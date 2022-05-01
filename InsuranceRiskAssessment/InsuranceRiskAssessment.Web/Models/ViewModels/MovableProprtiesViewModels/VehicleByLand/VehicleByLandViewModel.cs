using System.ComponentModel;
namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.VehicleByLand
{
    public class VehicleByLandViewModel : MovablePropertiesViewModel
    {
        [DisplayName("Вид гориво:")]
        public string FuelType { get; set; }
        [DisplayName("Парктроник")]
        public bool Parktronic { get; set; }
        [DisplayName("Най-чести маршрути:")]
        public string MostCommonRoutes { get; set; }
        [DisplayName("Рег. номер:")]
        public string RegisterNumber { get; set; }
    }
}
