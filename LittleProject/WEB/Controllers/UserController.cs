using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Service;
using WEB.Models;

namespace WEB.Controllers
{
    public class UserController : Controller
    {
        IUserService userService;
        IMapper mapper;

        public UserController(IUserService userService)
        {
            this.userService = userService;
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<Common.Entities.User, User>();
                c.CreateMap<User, Common.Entities.User>();
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
            ICollection<User> users = new List<User>();
            foreach (var item in userService.List())
            {
                if (item != null)
                {
                    User user = mapper.Map<Common.Entities.User, User>(item);
                    users.Add(user);
                }
            }


            return View(users.OrderBy(x=>x.Id));
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                userService.Create(mapper.Map<User, Common.Entities.User>(user));

                return RedirectToAction("Index", "Home");
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            User user = mapper.Map<Common.Entities.User, User>(userService.Get(id));
            EditModel edit = mapper.Map<User, EditModel>(user);

            return View(edit);
        }

        [HttpPost]
        public ActionResult Edit(EditModel edit)
        {
            if (ModelState.IsValid)
            {
                User user = mapper.Map<Common.Entities.User, User>(userService.Get(edit.Id));

                user.Name = edit.Name;
                user.MiddleName = edit.MiddleName;
                user.LastName = edit.LastName;
                user.Age = edit.Age;
                user.Phone = edit.Phone;
                user.Address = edit.Address;

                userService.Edit(mapper.Map<User, Common.Entities.User>(user));
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
                userService.Edit(mapper.Map<User, Common.Entities.User>(user));

                return RedirectToAction("Index", "Home");
            }

            return View(edit);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            userService.Delete(id);
            return RedirectToAction("All");
        }
    }
}