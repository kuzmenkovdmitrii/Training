using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using task15.Models;
using task15.Repository;

namespace task15.Controllers
{
    public class UserController : Controller
    {
        IUserRepository repository = new UserRepository();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult All()
        {

            return View(repository.List().OrderBy(x=>x.Id));
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            repository.Create(user);

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            User user = repository.Get(id);

            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            repository.Update(user);

            //try
            //{
            //    repository.Save();
            //}
            //catch (DbEntityValidationException ex)
            //{
            //    foreach (DbEntityValidationResult validationError in ex.EntityValidationErrors)
            //    {
            //        Response.Write("Object: " + validationError.Entry.Entity.ToString());
            //        Response.Write("");
            //        foreach (DbValidationError err in validationError.ValidationErrors)
            //        {
            //            Response.Write(err.ErrorMessage + "");
            //        }
            //    }
            //}

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("All");
        }
    }
}