using System.Web.Mvc;
using task14_2.Models;

namespace task14_2.Controllers
{
    public class CalculateController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(QuadraticEquation quadraticEquation)
        {
            quadraticEquation.CalculateRoots();

            ViewBag.FirstRoot = quadraticEquation.FirstRoot;
            ViewBag.SecondRoot = quadraticEquation.SecondRoot;

            return View(quadraticEquation);
        }
    }
}