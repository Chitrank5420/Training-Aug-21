using FarmPe.Data;
using FarmPe.GenericRepository;
using FarmPe.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Controllers
{
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IGenericRepository<Order> repository;
        private readonly IOrderData orderData;

        public OrderController(IGenericRepository<Order> repository, IOrderData orderData)
        {
            this.repository = repository;
            this.orderData = orderData;
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetOrders()
        {
            return Ok(repository.GetAll());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetOrder(int id)
        {
            return Ok(repository.GetById(id));
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddOrder(Order order)
        {
            repository.Insert(order);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                order.OrderId, order);
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditOrder(int id, Order order)
        {
            var existing = repository.GetById(id);
            if (existing != null)
            {
                order.OrderId = existing.OrderId;
                orderData.EditOrder(order);
            }
            return Ok();
        }


        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var order = repository.GetById(id);
            if (order != null)
            {
                repository.Delete(id);
                return Ok();
            }
            else
            {
                return NotFound("No order found");
            }
        }
    }
}
