using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        User ReadUser(long id);
        List<User> ReadUsers();
        List<User> ReadUsers(string searchUser);
        User UpdateUser(User user);
        User DeleteUser(User user);
    }
}
