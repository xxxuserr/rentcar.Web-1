using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace rentcar.BusinessObjects
{
    public class LoginBO
    {
        
        [Display(Name = "User Email")]
        [Required(ErrorMessage = "User Email is required!")]
        public string UserEmail { get; set; }
        [Display(Name = "User Password")]
        [Required(ErrorMessage = "User Password is required!")]
        public string Password { get; set; }
    }
}
