﻿using rentcar.DataAccess;
using rentcar.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rentcar.DataAccess.DbOperations;
using System.Security.Claims;

namespace rentcar.Web.Controllers
{
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        // GET: Home/Contact
        public ActionResult Contact()
        {
            return View();
        }
        // GET: Home/Offers
        public ActionResult Offers()
        {
            return View();
        }
        // GET: Home/Offers_suv
        public ActionResult Offers_suv()
        {
            return View();
        }
        // GET: Home/Offers_premium
        public ActionResult Offers_premium()
        {
            return View();
        }
        // GET: Home/About
        public ActionResult About()
        {
            return View();
        }
        // GET: Home/Blogpost
        public ActionResult Blogpost()
        {
            return View();
        }
        // GET: Home/Faq
        public ActionResult Faq()
        {
            return View();
        }
        // GET: Home/Offers
        public ActionResult Fleet()
        {
            return View();
        }
        // GET: Home/Team
        public ActionResult Team()
        {
            return View();
        }
        // GET: Home/Terms
        public ActionResult Terms()
        {
            return View();
        }
        // GET: Home/Testimonials
        public ActionResult Testimonials()
        {
            return View();
        }
        // GET: Home/Blog
        public ActionResult Blog()
        {
            return View();
        }
        // GET: Home/Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Reservations(UserRepository userRepository)
        {
            string userName = User.Identity.Name;
            List<ReservationBO> reservations = userRepository.GetReservationUser(userName);

            return View(reservations);
        }


    }
}