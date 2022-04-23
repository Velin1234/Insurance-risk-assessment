using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels
{
    public class MovablePropertiesViewModel : BaseViewModel
    {
        [Required]
        [DisplayName("Година на производство:")]
        public DateTime ManifactureYear { get; set; }
        [Required]
        [DisplayName("Притежание на обезопасителни средства")]
        public bool SecurityEquipmenPossession { get; set; }
        [Required]
        [DisplayName("Техническа изправност")]
        public bool TechnicalServiceability { get; set; }
        [Required]
        [DisplayName("Изминато разстояние(км.):")]
        public int DistanceTraveled { get; set; }
        [Required]
        [DisplayName("Височина(м.):")]
        public double Height { get; set; }
        [Required]
        [DisplayName("Тегло(кг.):")]
        public double Weight { get; set; }
        [Required]
        [DisplayName("Широчина(м.):")]
        public double Width { get; set; }
        [Required]
        [DisplayName("Държава:")]
        public string RegisteredCountry { get; set; }
        [Required]
        [DisplayName("Област:")]
        public string RegisteredRegion { get; set; }
        [Required]
        [DisplayName("Град/Село:")]
        public string RegisteredCity { get; set; }

    }
}
