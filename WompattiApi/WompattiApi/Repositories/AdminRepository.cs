using System;
using System.Collections.Generic;
using WompattiApi.Models;
using System.Linq;


namespace WompattiApi.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly WompattidbContext _context;

        public AdminRepository(WompattidbContext context)
        {
            _context = context;
        }

        public Admin CreateAdmin(Admin admin)
        {
            _context.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public Admin DeleteAdmin(Admin admin)
        {
            _context.Remove(admin);
            _context.SaveChanges();
            return admin;
        }

        public string ReadAdminHash(long id)
        {
            return _context.Admin
                .Where(a => a.Id == id)
                .Select(a => a.Hash)
                .SingleOrDefault();
        }

        public Admin ReadAdmin(long id)
        {
            return _context.Admin
                .Where(a => a.Id == id)
                .FirstOrDefault(a => a.Id == id);
        }

        public List<Admin> ReadAdmins()
        {
            return _context.Admin
                .ToList();
        }

        public List<Admin> ReadAdmins(string searchAdmin)
        {
            return _context.Admin
                .Where(a => a.Username.Contains(searchAdmin))
                .ToList();
        }

        public Admin UpdateAdmin(Admin admin)
        {
            _context.Update(admin);
            _context.SaveChanges();
            return admin;
        }
    }
}
