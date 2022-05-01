using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels
{
    public class RealEstatePropertyViewModel : BaseViewModel
    {
        [Required]
        [DisplayName("Държава:")]
        public string Country { get; set; }
        [Required]
        [DisplayName("Област:")]
        public string Region { get; set; }
        [Required]
        [DisplayName("Град/село:")]
        public string City { get; set; }
        [Required]
        [DisplayName("Адрес:")]
        public string Address { get; set; }
        [Required]
        [DisplayName("Пожарогасители")]
        public bool FireExtinguishers { get; set; }
        [Required]
        [DisplayName("Авариен изход")]
        public bool EmergencyExit { get; set; }
        [Required]
        [DisplayName("Площ(кв.м):")]
        public double SquareFeet { get; set; }
        [Required]
        [DisplayName("Алармена система")]
        public bool AlarmSystem { get; set; }
        [Required]
        [DisplayName("Газови бутилки")]
        public bool GasBottles { get; set; }
    }
}
