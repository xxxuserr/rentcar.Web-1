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
        // GET: Reservations/Booking
        public ActionResult Booking()
        {
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
    }
}
