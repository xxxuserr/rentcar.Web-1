using rentcar.DataAccess.DbOperations;
using System;
using System.Collections.Generic;
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
    }
}