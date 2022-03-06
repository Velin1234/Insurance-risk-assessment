using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding
{
    public class ResidentialBuildingViewModel: RealEstatePropertyViewModel
    {
        public string Floor { get; set; }
    }
}
