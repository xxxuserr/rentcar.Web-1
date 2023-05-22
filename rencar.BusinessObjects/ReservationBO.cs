using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Xml.Linq;

namespace rentcar.BusinessObjects
{
    public class ReservationBO
    {

        public int RId { get; set; }
        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is required!")]
        public string RUserName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required!")]
        public string RUserEmail { get; set; }
        [Display(Name = "Mark")]
        [Required(ErrorMessage = "Mark is required!")]
        public string RUserMark { get; set; }
        [Display(Name = "Model")]
        [Required(ErrorMessage = "Model is required!!")]
        public string RUserModel { get; set; }
        [Display(Name = "Pickup Date&Time")]
        [Required(ErrorMessage = "Pickup Date&Time is required!!")]
        public string RPickUpDateTime { get; set; }
        [Display(Name = "Drop Off Date&Time")]
        [Required(ErrorMessage = "Drop Off Date&Time is required!!")]
        public string RDropOffDateTime { get; set; }

        public enum Marks
        {
            Opel = 1,
            Volvo
        }

    }
}


