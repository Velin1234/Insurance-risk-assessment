using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding
{
<<<<<<< HEAD
    public class ResidentialBuildingEditViewModel : RealEstatePropertyViewModel
=======
    public class ResidentialBuildingEditViewModel: RealEstatePropertyViewModel
>>>>>>> main
    {
        [Required]
        [DisplayName("Етаж")]
        public string Floor { get; set; }

    }
}
