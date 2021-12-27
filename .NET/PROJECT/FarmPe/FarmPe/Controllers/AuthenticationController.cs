using FarmPe.Models;
using FarmPe.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticateService _authenticateService;
        public AuthenticationController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService;
        }
        [HttpPost]
        public IActionResult Post([FromBody]Users model)
        {
            var user = _authenticateService.Authenticate(model.UserName, model.Password);
            if (user == null)
                return BadRequest(new { message = "Invalid Credentials" });
            return Ok(user.Token);
        }
    }
}
