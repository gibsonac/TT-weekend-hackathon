using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace tenant_turner.Models
{

    public class User
    {
        [Key]
        [Column("id")]
        public int Userid { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "First name must be more than 2 characters!")]
        [Column("first_name", TypeName = "VARCHAR(255)")]
        [Display(Name = "First Name")]
        public string First_Name { get; set; }
        [Required]
        [MinLength(2, ErrorMessage = "Last name must be more than 2 characters!")]
        [Column("last_name", TypeName = "VARCHAR(255)")]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }
        [Required]
        [EmailAddress]
        [Column("email", TypeName = "VARCHAR(255)")]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Required]
        [SafePassword]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or longer!")]
        [Column("password", TypeName = "VARCHAR(255)")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Column("created_at")]
        public DateTime Created_At { get; set; } = DateTime.Now;
        [Column("updated_at")]
        public DateTime Updated_At { get; set; } = DateTime.Now;
        // lvl 1 = admin, full control
        //lvl 2 = property manager, control listings
        // lvl 3 = renters/normal users
        [Column("admin_lvl", TypeName = "TINYINT")]
        public int Admin_Lvl {get; set;} = 3; //defaults to lvl 3
        [Column("staff_pic")]
        public string Staff_pic {get; set;} = null; //defaults to none/null
        [Column("staff_bio")]
        public string Staff_bio {get; set;} = null; //defaults to none/null
        public List<Rental> Managed_Rentals {get; set;}

        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string password_confirm { get; set; }
    }
    public class SafePasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            var input = (string)value;

            ErrorMessage = string.Empty;
            var hasNumber = new Regex(@"[0-9]+");
            var hasChar = new Regex(@"[a-zA-Z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasChar.IsMatch(input))
            {
                return new ValidationResult("Password should atleast one letter, number, and character");
            }
            if (!hasNumber.IsMatch(input))
            {
                return new ValidationResult("Password should atleast one letter, number, and character");
            }

            if (!hasSymbols.IsMatch(input))
            {
                return new ValidationResult("Password should atleast one letter, number, and character");
            }
            else
            {
                return ValidationResult.Success;

            }
        }
    }
}
