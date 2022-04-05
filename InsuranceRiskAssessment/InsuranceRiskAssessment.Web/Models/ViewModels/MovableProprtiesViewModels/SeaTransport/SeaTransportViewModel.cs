using System.ComponentModel;

namespace InsuranceRiskAssessment.Web.Models.ViewModels.MovableProprtiesViewModels.SeaTransport
{
    public class SeaTransportViewModel : MovablePropertiesViewModel
    {
        [DisplayName("Маршрута минава ли през пиратска активност")]
        public bool DoesRoutePassesPirateZones { get; set; }
        [DisplayName("Функционалност")]
        public string Functionality { get; set; }
        [DisplayName("Начин на задвижване")]
        public string TypeOfMovability { get; set; }
        public string Name { get; set; }

    }
}
