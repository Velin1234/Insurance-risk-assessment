<<<<<<< HEAD
﻿using InsuranceRiskAssessment.DataAccessLayer.Data;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
=======
﻿namespace InsuranceRiskAssessment.DataAccessLayer.Entities.MovablePropertyEnities
>>>>>>> main
{
    public class AirTransport : MovableProperty
    {
        public string ClimatZone { get; set; }
        public string Functionality { get; set; }
        public virtual InsuranceBrokerUser InsuranceBroker { get; set; }

    }
}
