using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace tenant_turner.Models
{

    public class Application
    {
        [Key]
        [Column("id")]
        public int Applicationid { get; set; }
        
        [Column("pet", TypeName = "BOOLEAN")]
        [Display(Name = "Pet")]
        public bool Pet { get; set; }
        [Column("income", TypeName = "INT")]
        [Display(Name = "Income")]
        public int Income { get; set; }
        [Column("move_in_date")]
        [Display(Name = "Move In Date")]
        public DateTime Move_in_date { get; set; }
        [Column("eviction", TypeName = "BOOLEAN")]
        [Display(Name = "Eviction")]
        public bool Eviction { get; set; }
        [Column("bankruptcy", TypeName = "BOOLEAN")]
        [Display(Name = "Bankruptcy")]
        public bool Bankruptcy { get; set; }
        [Column("judgement", TypeName = "BOOLEAN")]
        [Display(Name = "Judgement")]
        public bool Judgement { get; set; }
        
        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public int Userid {get; set;}
    }
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime CurrentTime = DateTime.Now;
            if (((DateTime)value) < CurrentTime)
            {
                return new ValidationResult("Whoa time traveler, you need to pick a date in the future!");
            }
            return ValidationResult.Success;
        }
    }
}
