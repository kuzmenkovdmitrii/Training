using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.DTO;
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
                c.CreateMap<EditModel, User>();
                c.CreateMap<User, EditModel>();
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
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
                    User user = mapper.Map<UserDTO, User>(item);
                    users.Add(user);
                }
            }


            return View(users.OrderBy(x=>x.Id));
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            userService.Create(Mapper.Map<User, UserDTO>(user));

            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            User user = mapper.Map<UserDTO, User>(userService.Get(id));
            EditModel edit = mapper.Map<User, EditModel>(user);

            return View(edit);
        }

        [HttpPost]
        public ActionResult Edit(EditModel edit)
        {
            User user = mapper.Map<UserDTO,User>(userService.Get(edit.Id));

            user.Name = edit.Name;
            user.MiddleName = edit.MiddleName;
            user.LastName = edit.LastName;
            user.Age = edit.Age;
            user.Phone = edit.Phone;
            user.Address = edit.Address;

            userService.Edit(mapper.Map<User,UserDTO>(user));
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
            userService.Edit(mapper.Map<User, UserDTO>(user));

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {

            userService.Delete(id);
            return RedirectToAction("All");
        }
    }
}