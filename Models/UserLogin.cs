using System;  
using System.Collections.Generic;  
using System.ComponentModel.DataAnnotations;  
using System.Linq;  
using System.Web;  
  
namespace Estore.Models
{
    public class UserLogin
    {
        [Display(Name = "Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "User Email Id Required")]
        public string email { get; set; }
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password Required")]
        public string password { get; set; }

        [Display(Name = "Remember Me")]
        public bool Rememberme { get; set; }
    }
}