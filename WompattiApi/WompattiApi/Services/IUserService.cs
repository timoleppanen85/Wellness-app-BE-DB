using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Services
{
    public interface IUserService
    {
        User CreateUser(User user);
        User ReadUser(long id);
        List<User> ReadUsers();
        List<User> ReadUsers(string searchUser);
        User UpdateUser(User user, long id);
        User DeleteUser(long id);
    }
}
