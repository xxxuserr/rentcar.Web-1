using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Linq;
using rentcar.BusinessLogic;
using rentcar.DataAccess;
using rentcar.BusinessObjects;

namespace rentcar.Web.Controllers
{
    public class AccountsController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginBO objLoginBO)
        {
            if (ModelState.IsValid)
            {
                UserBL objLoginBl = new UserBL();
                CustomBO objCustomBo = objLoginBl.Login(objLoginBO);
                return RedirectToAction("Index", "Home");
            }
            ModelState.AddModelError("", "User or password is wrong");
            return View(objLoginBO);

        }
        [HttpPost]
        public ActionResult SignUp(UserBO objUserBO)
        {
            if (ModelState.IsValid)
            {
                UserBL objUserBl = new UserBL();
                CustomBO objCustomBo = objUserBl.AddUser(objUserBO);
                return RedirectToAction("Index", "Home");
            }
            return View(objUserBO);
        }
        public ActionResult Signout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}