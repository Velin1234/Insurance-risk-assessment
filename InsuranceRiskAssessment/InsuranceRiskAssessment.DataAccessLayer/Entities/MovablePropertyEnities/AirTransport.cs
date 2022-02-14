using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
{
    public class AirTransport : MovableProperty
    {
        public string ClimatZone { get; set; }
        public string Functionality { get; set; }
    }
}
