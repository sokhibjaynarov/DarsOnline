using DarsOnline.Domain.Entities;
using DarsOnline.Service.DTOs;
using DarsOnline.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DarsOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService userService;
        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public User Create(UserForCreationDto userDto)
        {
            return userService.Create(userDto);
        }

        [HttpGet]
        [Route("id")]
        public User Get(int id)
        {
            return userService.Get(p => p.Id == id);
        }

        [HttpGet]
        public IEnumerable<User> GetAll()
        {
            return userService.GetAll();
        }

        [HttpDelete]
        public bool Delete(int id)
        {
            return userService.Delete(p => p.Id == id);
        }

        [HttpPut]
        public User Update(int id, User user)
        {
            return userService.Update(id, user);
        }
    }
}
