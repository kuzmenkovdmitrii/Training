using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace task14.Controllers
{
    public class InformationController : Controller
    {
        //[Route("Info")]
        public ActionResult Index()
        {
            return View();
        }
    }
}