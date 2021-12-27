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
    public class CustomerController : ControllerBase
    {
        public ICustomerData _customerData;

        public CustomerController(ICustomerData customerData)
        {
            _customerData = customerData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetCustomers()
        {
            return Ok(_customerData.GetCustomers());
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddCustomer(Customer  customer)
        {
            _customerData.AddCustomer(customer);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                customer.CustomerId, customer);
        }
        
        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditCustomer(int id,Customer customer)
        {
            var existingCustomer = _customerData.GetCustomer(id);
            if(existingCustomer != null)
            {
                customer.CustomerId = existingCustomer.CustomerId;
                _customerData.EditCustomer(customer);
            }
            return Ok();
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteCustomer(int id)
        {
            var cus = _customerData.GetCustomer(id);
            if(cus != null)
            {
                _customerData.DeleteCustomer(cus);
                return Ok();
            }
            else
            {
                return NotFound("No customer found");
            }
        }




    }
}
