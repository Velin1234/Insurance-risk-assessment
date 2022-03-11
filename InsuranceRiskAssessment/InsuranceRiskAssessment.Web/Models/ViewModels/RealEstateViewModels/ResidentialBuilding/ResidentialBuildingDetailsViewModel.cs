using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.ResidentialBuilding
{
    public class ResidentialBuildingDetailsViewModel: RealEstatePropertyViewModel
    {
        public string Floor { get; set; }
    }
}
