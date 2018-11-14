using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using task15.Models;
using task15.Repository;

namespace task15.Controllers
{
    public class UserController : Controller
    {
        IUserRepository repository = new UserRepository();
        IMapper mapper;

        public UserController()
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<EditModel, User>();
                c.CreateMap<User, EditModel>();
            });
            mapper = config.CreateMapper();
        }

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
            EditModel edit = mapper.Map<User, EditModel>(repository.Get(id));

            return View(edit);
        }

        [HttpPost]
        public ActionResult Edit(EditModel edit)
        {
            User user = repository.Get(edit.Id);

            user.Name = edit.Name;
            user.MiddleName = edit.MiddleName;
            user.LastName = edit.LastName;
            user.Age = edit.Age;
            user.Phone = edit.Phone;
            user.Address = edit.Address;

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