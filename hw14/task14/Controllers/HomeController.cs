using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task14.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Info()
        {
            return RedirectToAction("Index", "Information");
        }

        public ActionResult City()
        {
            return RedirectToAction("Index", "City");
        }
    }
}