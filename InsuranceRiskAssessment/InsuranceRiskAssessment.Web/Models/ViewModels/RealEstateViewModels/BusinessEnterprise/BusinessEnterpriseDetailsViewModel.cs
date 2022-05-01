using System.ComponentModel;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.RealEstateViewModels.BusinessEnterprise
{
    public class BusinessEnterpriseDetailsViewModel : RealEstatePropertyViewModel
    {
        [DisplayName("Предназначение на предприятието:")]
        public string PurposeOfTheEnterprise { get; set; }

    }
}
