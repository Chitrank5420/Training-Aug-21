using FarmPe.Data;
using FarmPe.GenericRepository;
using FarmPe.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Controllers
{
    [Authorize]   
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IGenericRepository<User> repository;
        private readonly IUserData userData;
       
        public UserController(IGenericRepository<User> repository,IUserData userData)
        {
            this.repository = repository;
            this.userData = userData;
        }

        
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetUsers()
        {
            return Ok(repository.GetAll());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetUser(int id)
        {
            return Ok(repository.GetById(id));
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddUser(User user)
        {
            repository.Insert(user);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                user.UserId, user);
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditUser(int id, User user)
        {
            var existingUser = repository.GetById(id);
            if (existingUser != null)
            {
                user.UserId = existingUser.UserId;
                userData.EditUser(user);
            }
            return Ok();
        }


        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = repository.GetById(id);
            if (user != null)
            {
                repository.Delete(id);
                return Ok();
            }
            else
            {
                return NotFound("No User found");
            }
        }
       
    }
}
