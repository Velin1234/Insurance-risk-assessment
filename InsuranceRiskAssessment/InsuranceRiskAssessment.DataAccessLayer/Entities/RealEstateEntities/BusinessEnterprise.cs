<<<<<<< HEAD
﻿using InsuranceRiskAssessment.DataAccessLayer.Data;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities
=======
﻿namespace InsuranceRiskAssessment.DataAccessLayer.Entities.RealEstateEntities
>>>>>>> main
{
    public class BusinessEnterprise : RealEstateProperty
    {
        public string PurposeOfTheEnterprise { get; set; }
        public virtual InsuranceBrokerUser InsuranceBroker { get; set; }

    }
}
