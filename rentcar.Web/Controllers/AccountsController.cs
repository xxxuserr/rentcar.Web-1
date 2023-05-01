using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using rentcar.Web.Models;
using System.Linq;
using rentcar.BusinessLogic;
using rentcar.DataAccess;
using rentcar.BusinessObjects;

namespace rentcar.Web.Controllers
{
    public class AccountsController : Controller
    {
        public ActionResult Signup()
        {
            return View();
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
    }
}