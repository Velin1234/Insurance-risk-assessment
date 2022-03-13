using System.ComponentModel;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding
{
    public class ResidentialBuildingViewModel : RealEstatePropertyViewModel
    {
        [DisplayName("Етаж")]
        public string Floor { get; set; }
    }
}
