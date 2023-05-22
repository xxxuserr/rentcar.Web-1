using rentcar.BusinessLogic;
using rentcar.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rentcar.Web.Controllers
{
    
    public class ReservationsController : Controller
    {
        [Authorize]
        // GET: Reservations/Booking
        public ActionResult Booking()
        {
            ViewData["PickupTimeOptions"] = GetPickupTimeOptions();
            ViewData["DropOffTimeOptions"] = GetDropOffTimeOptions();

            return View();
        }
        [HttpPost]
        public ActionResult Booking(ReservationBO objReservationBO)
        {
            if (ModelState.IsValid)
            {
                ReservationBL objReservationBl = new ReservationBL();
                CustomBO objCustomBo = objReservationBl.AddReservation(objReservationBO);
                return RedirectToAction("Index", "Home");
            }
            return View(objReservationBO);
        }
        public IEnumerable<SelectListItem> GetPickupTimeOptions()
        {
            List<SelectListItem> pickupTimes = new List<SelectListItem>
        {
        new SelectListItem { Value = "08:00", Text = "8:00 AM" },
        new SelectListItem { Value = "09:00", Text = "9:00 AM" },
        new SelectListItem { Value = "10:00", Text = "10:00 AM" },
        new SelectListItem { Value = "11:00", Text = "11:00 AM" },
        new SelectListItem { Value = "12:00", Text = "12:00 AM" },
        new SelectListItem { Value = "13:00", Text = "13:00 AM" },
        new SelectListItem { Value = "14:00", Text = "13:00 AM" },
        new SelectListItem { Value = "15:00", Text = "13:00 AM" },
        new SelectListItem { Value = "16:00", Text = "13:00 AM" },
        };
            return pickupTimes;
        }
        public IEnumerable<SelectListItem> GetDropOffTimeOptions()
        {
            List<SelectListItem> pickupTimes = new List<SelectListItem>
        {
        new SelectListItem { Value = "08:00", Text = "8:00 AM" },
        new SelectListItem { Value = "09:00", Text = "9:00 AM" },
        new SelectListItem { Value = "10:00", Text = "10:00 AM" },
        new SelectListItem { Value = "11:00", Text = "11:00 AM" },
        new SelectListItem { Value = "12:00", Text = "12:00 AM" },
        new SelectListItem { Value = "13:00", Text = "13:00 AM" },
        new SelectListItem { Value = "14:00", Text = "13:00 AM" },
        new SelectListItem { Value = "15:00", Text = "13:00 AM" },
        new SelectListItem { Value = "16:00", Text = "13:00 AM" },
        };
            return pickupTimes;
        }
    }
}
