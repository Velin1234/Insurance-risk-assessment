<<<<<<< HEAD
﻿using InsuranceRiskAssessment.DataAccessLayer.Data;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
=======
﻿namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
>>>>>>> main
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
