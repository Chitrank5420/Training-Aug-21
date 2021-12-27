using Assignment.CustomerData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    
    [ApiController]
    public class ToyController : ControllerBase
    {
        private IToyData _toyData;
        public ToyController(IToyData toyData)
        {
            _toyData = toyData;
        }
        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetToy(int id)
        {
            var toy = _toyData.GetToy(id);
            if(toy != null)
            {
                return Ok(toy);
            }    
            else
            {
                return NotFound("No Toy Found");
            }
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetToys()
        {
            return Ok(_toyData.GetToys());
        }

    }
}
