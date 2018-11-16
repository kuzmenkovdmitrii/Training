using System.Collections.Generic;
using Common.Entities;

namespace BLL.Service
{
    public interface IUserService
    {
        IEnumerable<User> List();
        User Get(int id);

        void Create(User user);
        void Edit(User user);
        void Delete(int id);
    }
}
