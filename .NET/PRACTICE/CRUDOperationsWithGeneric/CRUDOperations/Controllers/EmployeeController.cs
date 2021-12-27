using CRUDOperations.EmployeeData;
using CRUDOperations.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDOperations.Controllers
{
    
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IGenericRepository<Employee> repository = null;
        public EmployeeController(IGenericRepository<Employee> repository)
        {
            this.repository = repository;
        }
        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult Index()
        {
            var model = repository.GetAll();
            return Ok(model); 
        }
        [Route("api/[controller]")]
        [HttpPost]
        public IActionResult AddEmployee(Employee model)
        {
            repository.Insert(model);
            repository.Save();
            return Ok();
        }
    }
}
