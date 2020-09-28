using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;
using WompattiApi.Repositories;

namespace WompattiApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User CreateUser(User user)
        {
            return _userRepository.CreateUser(user);
        }

        public User DeleteUser(long id)
        {
            User user = ReadUser(id);
            return _userRepository.DeleteUser(user);
        }

        public User ReadUser(long id)
        {
            return _userRepository.ReadUser(id);
        }

        public List<User> ReadUsers()
        {
            return _userRepository.ReadUsers();
        }

        public List<User> ReadUsers(string searchUser)
        {
            return _userRepository.ReadUsers(searchUser);
        }

        public User UpdateUser(User user, long id)
        {
            if (user != null)
            {
                if (user.Id.Equals(id))
                {
                    return _userRepository.UpdateUser(user);
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
