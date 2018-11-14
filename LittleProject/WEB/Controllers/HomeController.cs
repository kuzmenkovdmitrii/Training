using System.Web.Mvc;

namespace WEB.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return RedirectToAction("Create", "User");
        }

        public ActionResult All()
        {
            return RedirectToAction("All", "User");
        }
    }
}