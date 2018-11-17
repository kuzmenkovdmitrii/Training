using System.Collections;
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
        public ActionResult All(int page = 1)
        {

            return View();
        }

        public ActionResult UsersPage(string sortOrder, int page = 1)
        {
            int pageSize = 20;

            var users = mapper.Map<IEnumerable<Common.Entities.User>, IEnumerable<User>>(userService.List());

            if (sortOrder == "" || sortOrder == "Id")
            {
                users = users.OrderBy(x => x.Id);
            }
            else if (sortOrder == "Name")
            {
                users = users.OrderBy(x => x.Name);
            }
            else if (sortOrder == "LastName")
            {
                users = users.OrderBy(x => x.LastName);
            }
            else if (sortOrder == "MiddleName")
            {
                users = users.OrderBy(x => x.MiddleName);
            }

            IEnumerable<User> userPage = users.Skip((page - 1) * pageSize).Take(pageSize);

            return PartialView(userPage.OrderBy(x => x.Id));
        }

        //public ActionResult UsersPage(int page, int startIndex, int pageSize = 20)
        //{
        //    var users = mapper.Map<IEnumerable<Common.Entities.User>, IEnumerable<User>>(userService.List());

        //    //IEnumerable<User> userPerPage = users.Skip((page - 1) * pageSize).Take(pageSize);

        //    IEnumerable<User> userPage = users.Skip((page - 1) * pageSize).Take(pageSize);

        //    return PartialView(userPage.OrderBy(x => x.Id));
        //}

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