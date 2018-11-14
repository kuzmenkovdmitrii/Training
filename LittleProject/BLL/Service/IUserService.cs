using System.Collections.Generic;
using BLL.DTO;

namespace BLL.Service
{
    public interface IUserService
    {
        IEnumerable<UserDTO> List();
        UserDTO Get(int id);

        void Create(UserDTO user);
        void Edit(UserDTO user);
        void Delete(int id);
    }
}
