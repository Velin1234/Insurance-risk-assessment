using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
{
    public class VehicleByLand : MovableProperty
    {
        public string FuelType { get; set; }
        public bool Parktronic { get; set; }
        public string MostCommonRoutes { get; set; }
        public string RegisterNumber { get; set; }
    }
}
