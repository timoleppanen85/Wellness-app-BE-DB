using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Repositories
{
    public interface IAdminRepository
    {
        Admin CreateAdmin(Admin admin);
        Admin ReadAdmin(long id);
        List<Admin> ReadAdmins();
        string ReadAdminHash (long id);
        List<Admin> ReadAdmins(string searchAdmin);
        Admin UpdateAdmin(Admin admin);
        Admin DeleteAdmin(Admin admin);
    }
}
