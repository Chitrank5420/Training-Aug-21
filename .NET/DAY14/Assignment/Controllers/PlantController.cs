using Assignment.CustomerData;
using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    
    [ApiController]
    public class PlantController : ControllerBase
    {
        private IPlantData _plantData;
        public PlantController(IPlantData plantData)
        {
            _plantData = plantData;
        }
        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetPlants()
        {
            return Ok(_plantData.GetPlants());
            
        }
        [Route("api/[controller]")]
        public IActionResult AddPlants(Plant plant)
        {
            _plantData.AddPlant(plant);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                plant.PlantId, plant);
        }
    }
}
