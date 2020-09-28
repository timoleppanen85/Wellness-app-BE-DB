using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WompattidbContext _context;

        public UserRepository(WompattidbContext context)
        {
            _context = context;
        }

        public User CreateUser(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
            return user;
        }

        public User DeleteUser(User user)
        {
            _context.Remove(user);
            _context.SaveChanges();
            return user;
        }

        public User ReadUser(long id)
        {
            return _context.User
                .Where(u => u.Id == id)
                .FirstOrDefault(u => u.Id == id);
        }

        public List<User> ReadUsers()
        {
            return _context.User
                .ToList();
        }

        public List<User> ReadUsers(string searchUser)
        {
            return _context.User
                .Where(u => u.Username.Contains(searchUser))
                .ToList();
        }

        public User UpdateUser(User user)
        {
            _context.Update(user);
            _context.SaveChanges();
            return user;
        }
    }
}
