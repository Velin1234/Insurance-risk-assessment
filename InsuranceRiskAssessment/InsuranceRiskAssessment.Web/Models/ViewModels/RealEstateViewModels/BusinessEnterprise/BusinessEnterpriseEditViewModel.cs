using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.BusinessEnterprise
{
    public class BusinessEnterpriseEditViewModel : RealEstatePropertyViewModel
    {
        [Required]
        [DisplayName("Предназначение на предприятието:")]
        public string PurposeOfTheEnterprise { get; set; }
    }
}
