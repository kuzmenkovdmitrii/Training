using System.Collections.Generic;
using BLL.Infrastructure;
using Common.Entities;
using DAL.Repository.Interface;

namespace BLL.Service
{
    public class UserService : IUserService
    {
        IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public IEnumerable<User> List()
        {
            return userRepository.List();
        }

        public User Get(int id)
        {
            if (id == null)
            {
                throw new ValidationException("Id is empty", "");
            }

            User user = userRepository.Get(id);
            if (user != null)
            {
                return user;
            }

            throw new ValidationException("User not found", "");
        }

        public void Create(User user)
        {
            userRepository.Create(user);
        }

        public void Delete(int id)
        {
            userRepository.Delete(id);
        }

        public void Edit(User user)
        {
            userRepository.Update(user);
        }
    }
}
