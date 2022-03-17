using System.ComponentModel;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.BusinessEnterprise
{
    public class BusinessEnterpriseViewModel : RealEstatePropertyViewModel
    {
        [DisplayName("Предмет на дейност")]
        public string PurposeOfTheEnterprise { get; set; }
    }
}
