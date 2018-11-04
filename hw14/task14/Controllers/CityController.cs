using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task14.Controllers
{
    public class CityController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Australia()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Belarus()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Ukraine()
        {
            return View();
        }
    }
}