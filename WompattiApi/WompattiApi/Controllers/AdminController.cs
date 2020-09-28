using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WompattiApi.Models;
using WompattiApi.Services;

namespace WompattiApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpPost]
        public ActionResult<Admin> CreateAdmin(Admin admin, string password)
        {
            return new JsonResult(_adminService.CreateAdmin(admin, password));
        }

        [HttpGet]
        public ActionResult<List<Admin>> ReadAdmins()
        {
            return new JsonResult(_adminService.ReadAdmins());
        }

        [HttpGet("{id}")]
        public ActionResult<Admin> ReadAdmin(long id)
        {
            return new JsonResult(_adminService.ReadAdmin(id));
        }

        [HttpGet("search/{userName}")]
        public ActionResult<Admin> ReadAdmin(string userName)
        {
            return new JsonResult(_adminService.ReadAdmins(userName));
        }

        [HttpPut("{id}")]
        public ActionResult<Admin> UpdateAdmin(Admin admin, long id, string password)
        {
            return new JsonResult(_adminService.UpdateAdmin(admin, id, password));
        }

        [HttpDelete("{id}")]
        public ActionResult<Admin> DeleteAdmin(long id)
        {
            return new JsonResult(_adminService.DeleteAdmin(id));
        }

    }
}