using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding
{
<<<<<<< HEAD
    public class ResidentialBuildingAddViewModel : RealEstatePropertyViewModel
=======
    public class ResidentialBuildingAddViewModel: RealEstatePropertyViewModel
>>>>>>> main
    {
        [Required]
        [DisplayName("Етаж")]
        public string Floor { get; set; }

    }
}
