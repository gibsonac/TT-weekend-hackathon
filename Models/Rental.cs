using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace tenant_turner.Models
{

    public class Rental
    {
        [Key]
        [Column("id")]
        public int Rentalid { get; set; }
        [Required]
        [MinLength(10, ErrorMessage = "You must have a title longer than 10 characters!")]
        [Column("title", TypeName = "VARCHAR(255)")]
        [Display(Name = "Title")]
        public string Title { get; set; }
        [Required]
        [MinLength(30, ErrorMessage = "You must have a description longer than 30 characters!")]
        [Column("description")]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        [Column("address", TypeName = "TEXT")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        [Column("bedrooms", TypeName = "TINYINT")]
        [Display(Name = "Bedrooms")]
        public int Bedrooms { get; set; }
        [Column("bathrooms", TypeName = "DOUBLE(8,2)")]
        [Display(Name = "Bathrooms")]
        public double Bathrooms { get; set; }
        [Column("pets", TypeName = "BOOLEAN")]
        [Display(Name = "Pets")]
        public bool Pets { get; set; }
        [Column("sqft", TypeName = "INT")]
        [Display(Name = "Square Feet")]
        public int Sqft { get; set; } = 0;
        [Column("restrictions", TypeName = "TEXT")]
        [Display(Name = "Restrictions")]
        public string Restrictions { get; set; }
        [Column("deposit", TypeName = "INT")]
        [Display(Name = "Deposit")]
        public int Deposit { get; set; }

        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public int Userid {get; set;}
        public User Property_Manager {get; set;}
        public List<Picture> Pictures {get; set;}
    }
}
