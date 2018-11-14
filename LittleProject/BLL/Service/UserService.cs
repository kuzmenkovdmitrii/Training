using System.Collections.Generic;
using AutoMapper;
using BLL.DTO;
using DAL.Domain;
using DAL.Repository.Interface;

namespace BLL.Service
{
    public class UserService : IUserService
    {
        IUserRepository userRepository;
        IMapper mapper;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;

            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<UserDTO, User>();
                c.CreateMap<User, UserDTO>();
            });
            mapper = config.CreateMapper();
        }

        public IEnumerable<UserDTO> List()
        {
            return mapper.Map<IEnumerable<User>, List<UserDTO>>(userRepository.List());
        }

        public UserDTO Get(int id)
        {
            User user = userRepository.Get(id);

            if (user != null)
            {
                return mapper.Map<User, UserDTO>(user);
            }

            return null;
        }

        public void Create(UserDTO userDTO)
        {
            User user = mapper.Map<UserDTO, User>(userDTO);
            userRepository.Create(user);
        }

        public void Delete(int id)
        {
            userRepository.Delete(id);
        }

        public void Edit(UserDTO userDTO)
        {
            User user = mapper.Map<UserDTO, User>(userDTO);
            userRepository.Update(user);
        }
    }
}
