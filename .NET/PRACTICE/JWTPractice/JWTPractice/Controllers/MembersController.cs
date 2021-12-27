using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWTPractice.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly IJwtAuth jwtAuth;
        // GET: api/<MembersController>
        private readonly List<Member> lstMember = new List<Member>()
        {
            new Member{Id=1,Name = "Chitrank"},
            new Member{Id=2,Name = "Kruti"},
            new Member{Id=3,Name = "Nilesh"}
        };
        public MembersController(IJwtAuth jwtAuth)
        {
            this.jwtAuth = jwtAuth;
        }

        [HttpGet]
        public IEnumerable<Member> AllMembers()
        {
            return lstMember;
        }

        [HttpGet("{id}")]
        public Member MemberByid(int id)
        {
            return lstMember.Find(x => x.Id == id);
        }

        

        [AllowAnonymous]
        [HttpPost("authentication")]
        public IActionResult Authentication([FromBody]UserCredential userCredential)
        {
            var token = jwtAuth.Authentication(userCredential.UserName, userCredential.Password);
            if(token == null)
            {
                return Unauthorized();
            }
            return Ok(token);
        }
    }
}
