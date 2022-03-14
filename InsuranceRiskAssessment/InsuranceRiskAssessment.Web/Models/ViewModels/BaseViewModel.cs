using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InsuranceRiskAssessment.Web.Models.ViewModels
{
    public class BaseViewModel
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Създадено")]
        public DateTime CreatedAt { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Променено")]
        public DateTime ModifiedAt { get; set; }

        [ScaffoldColumn(false)]
        [DisplayName("Предишни инциденти")]
        public bool PreviousAccidents { get; set; }

        [DisplayName("Резултат")]
        public int ResultValue { get; set; }

    }
}
