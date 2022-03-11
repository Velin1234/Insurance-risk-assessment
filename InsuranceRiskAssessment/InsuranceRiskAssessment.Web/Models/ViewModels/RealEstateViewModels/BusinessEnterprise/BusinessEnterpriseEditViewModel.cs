using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.BusinessEnterprise
{
    public class BusinessEnterpriseEditViewModel : RealEstatePropertyViewModel
    {
        [Required]
        [DisplayName("Предмет на дейност")]
        public string PurposeOfTheEnterprise { get; set; }
    }
}
