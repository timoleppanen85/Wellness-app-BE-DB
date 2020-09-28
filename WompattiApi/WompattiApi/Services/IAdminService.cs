using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WompattiApi.Models;

namespace WompattiApi.Services
{
    public interface IAdminService
    {
        Admin CreateAdmin(Admin admin, string password);
        Admin ReadAdmin(long id);
        List<Admin> ReadAdmins();
        List<Admin> ReadAdmins(string userName);
        Admin UpdateAdmin(Admin admin, long id, string password);
        Admin DeleteAdmin(long id);
    }
}
