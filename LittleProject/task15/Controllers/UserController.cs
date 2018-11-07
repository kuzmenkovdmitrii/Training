using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using task15.Models;

namespace task15.Controllers
{
    public class UserController : Controller
    {
        IRepository repository = new UserRepository();

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public ActionResult All()
        {

            return View(repository.List());
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            repository.Create(user);
            repository.Save();
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
            repository.Save();

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
            return RedirectToAction("All");
        }
    }
}