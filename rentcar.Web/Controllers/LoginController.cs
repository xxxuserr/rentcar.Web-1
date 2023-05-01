//using System;
//using System.Collections.Generic;
//using System.Web;
//using System.Web.Mvc;
//using System.Web.Security;
//using rentcar.Web.Models;
//using System.Linq;
//using rentcar.BusinessLogic;

//namespace rentcar.Web.Controllers
//{
//    public class AccountsController : Controller
//    {
//        RENT_DBEntities entity = new RENT_DBEntities();
//        public ActionResult Login()
//        {
//            return View();
//        }

//        public ActionResult Signup()
//        {
//            return View();
//        }

//        [HttpPost]
//        public ActionResult Login(LoginViewModel credentials)
//        {
//            bool userExists = entity.UsersTbls.Any(x => x.Email == credentials.Email && x.Passcode == credentials.Password);
//            UsersTbl u = entity.UsersTbls.FirstOrDefault(x => x.Email == credentials.Email && x.Passcode == credentials.Password);
//            if (userExists)
//            {
//                FormsAuthentication.SetAuthCookie(u.Username, false);
//                return RedirectToAction("Index", "Home");
//            }
//            ModelState.AddModelError("", "User or password is wrong");
//            return View();
//        }
//        [HttpPost]

//        public ActionResult Signup(UsersTbl userinfo)
//        {
//            entity.UsersTbls.Add(userinfo);
//            entity.SaveChanges();
//            return RedirectToAction("Login");
//        }

//        public ActionResult Signout()
//        {
//            FormsAuthentication.SignOut();
//            return RedirectToAction("Login");
//        }
//    }
//}