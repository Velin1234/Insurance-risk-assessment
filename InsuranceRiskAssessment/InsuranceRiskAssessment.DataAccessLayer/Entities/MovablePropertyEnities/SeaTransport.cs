using InsuranceRiskAssessment.DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
{
    public class SeaTransport : MovableProperty
    {
        public string ClimatZone { get; set; }
        public bool DoesRoutePassesPirateZones { get; set; }
        public string Functionality { get; set; }
        public string TypeOfMovability { get; set; }

        public virtual InsuranceBrokerUser InsuranceBroker { get; set; }

    }
}
