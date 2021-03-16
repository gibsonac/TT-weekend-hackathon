using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace tenant_turner.Models
{

    public class Picture
    {
        [Key]
        [Column("id")]
        public int Pictureid { get; set; }
        
        [Column("url", TypeName = "TEXT")]
        [Display(Name = "URL")]
        public string Url { get; set; }
        public int Rentalid {get; set;}
        
        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        public Rental RelatedHome {get;set;}
    }
}
