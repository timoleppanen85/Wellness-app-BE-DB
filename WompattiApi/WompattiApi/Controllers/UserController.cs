using Microsoft.AspNetCore.Mvc;
using WompattiApi.Services;
using WompattiApi.Models;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace WompattiApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public ActionResult<User> CreateUser(User user)
        {
            return new JsonResult(_userService.CreateUser(user));
        }

        [HttpGet]
        public ActionResult<List<User>> ReadUsers()
        {
            return new JsonResult(_userService.ReadUsers());
        }

        [HttpGet("{id}")]
        public ActionResult<User> ReadUser(long id)
        {
            return new JsonResult(_userService.ReadUser(id));
        }

        [HttpGet("search/{userName}")]
        public ActionResult<List<User>> ReadUsers(string userName)
        {
            return new JsonResult(_userService.ReadUsers(userName));
        }

        [HttpPut("{id}")]
        public ActionResult<User> UpdateUser(User user, long id)
        {
            return new JsonResult(_userService.UpdateUser(user, id));
        }

        [HttpDelete("{id}")]
        public ActionResult<User> DeleteUser(long id)
        {
            return new JsonResult(_userService.DeleteUser(id));
        }
    }
}