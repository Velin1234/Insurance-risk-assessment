using System.ComponentModel;
<<<<<<< HEAD

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding
{
    public class ResidentialBuildingViewModel : RealEstatePropertyViewModel
=======
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding
{
    public class ResidentialBuildingViewModel: RealEstatePropertyViewModel
>>>>>>> main
    {
        [DisplayName("Етаж")]
        public string Floor { get; set; }
    }
}
