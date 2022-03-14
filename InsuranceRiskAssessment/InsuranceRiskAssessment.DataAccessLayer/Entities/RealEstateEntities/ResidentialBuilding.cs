<<<<<<< HEAD
﻿using InsuranceRiskAssessment.DataAccessLayer.Data;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities
=======
﻿namespace InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities
>>>>>>> main
{
    public class ResidentialBuilding : RealEstateProperty
    {
        public string Floor { get; set; }
        public virtual InsuranceBrokerUser InsuranceBroker { get; set; }

    }
}
