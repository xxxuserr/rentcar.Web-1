using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace rentcar.BusinessObjects
{
    public class UserBO
    {
        public int UserId { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required!")]
        public string UserName { get; set; }
        [Display(Name = "User Email")]
        [Required(ErrorMessage = "User Email is required!")]

        public string UserEmail { get; set; }
        [Display(Name = "User Password")]
        [Required(ErrorMessage = "User Password is required!")]

        public string Password { get; set; }

    }
}
