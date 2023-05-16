using rentcar.BusinessObjects;
using rentcar.DataAccess;
using rentcar.DataAccess.DbOperations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rentcar.Web.Controllers
{
    public class AdminController : Controller
    {
        UserRepository repository = null;
        public AdminController()
        {
            repository = new UserRepository();
        }
        // GET: Admin
        [Authorize(Roles ="Admin")]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Users()
        {
            var result = repository.GetUsers();
            return View(result);
        }
        public ActionResult CreateUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateUser(UserBO model)
        {
            if (ModelState.IsValid)
            {
                int id = repository.CreateUser(model);
                if (id > 0)
                {
                    ModelState.Clear();
                    ViewBag.Issucces = "Data Added";
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
           
            repository.DeleteUser(id);
            return RedirectToAction("Users");
        }
    }
}