using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing.Controllers
{
    
    [ApiController]
    [Route("Employee")]
    public class EmployeeControllers : ControllerBase
    {
      
        [Route("Emp/All")]
        [Route("AllEmp")]
        public string GetAllEmployees()
        {
            return "Response from GetAllEmployees";
        }
        [Route("Emp/ById")]
        public string GetEmployeeById()
        {
            return "Response from GetEmployeeById";
        }
        [Route("{Id}")]
        public string GetEmployeeById(int id)
        {
            return $"Return Employee Details : {id}";
        }
        [Route("Gender/{Gender}/City/{CityId}")]
        public string GetEmployeesByGenderAndCity(string Gender, int CityId)
        {
            return $"Return Employees with Gender : {Gender}, City: {CityId}";
        }
        //[Route("Employee/Search")]
        //public string SearchEmployees(string Department)
        //{
        //    return $"Return Employees with Department : {Department}";
        //}
        [Route("Search")]
        public string SearchEmployees(string Department, string Gender, string City)
        {
            return $"Return Employees with Department : {Department}, Gender : {Gender}, City : {City}";
        }
    }
}
