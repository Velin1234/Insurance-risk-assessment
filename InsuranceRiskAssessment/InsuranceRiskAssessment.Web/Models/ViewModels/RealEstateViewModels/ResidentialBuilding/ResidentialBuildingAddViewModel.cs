using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding
{
    public class ResidentialBuildingAddViewModel: RealEstatePropertyViewModel
    {
        [Required]
        [DisplayName("Етаж")]
        public string Floor { get; set; }

    }
}
