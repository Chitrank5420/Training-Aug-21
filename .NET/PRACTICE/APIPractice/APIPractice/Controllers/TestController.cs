using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIPractice.Controllers
{
    [ApiController]
    [Route("test/{action}")]
    public class TestController : ControllerBase
    {
        public string Get()
        {
            return "Returning from TestController Get Method";
        }
        public string Get2()
        {
            return "Returning from TestController Get2 Method";
        }
    }
}
