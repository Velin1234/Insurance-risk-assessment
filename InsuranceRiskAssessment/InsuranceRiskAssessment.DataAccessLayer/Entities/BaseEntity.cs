using System;

namespace InsuranceRiskAssessment.DataAccessLayer.Entities
{
    public abstract class BaseEntity
    {
        public BaseEntity()
        {
            CreatedAt = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool PreviousAccidents { get; set; }
        public int ResultValue { get; set; }
    }
}
