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
    public class OrderDetailsController : ControllerBase
    {
        private readonly IGenericRepository<OrderDetail> repository;
        private readonly IOrderDetailsData orderDetailsData;

        public OrderDetailsController(IGenericRepository<OrderDetail> repository, IOrderDetailsData orderDetailsData)
        {
            this.repository = repository;
            this.orderDetailsData = orderDetailsData;
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetOrderDetails()
        {
            return Ok(repository.GetAll());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetOrderDetail(int id)
        {
            return Ok(repository.GetById(id));
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddOrderDetail(OrderDetail orderDetail)
        {
            repository.Insert(orderDetail);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                orderDetail.OrderId, orderDetail);
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditOrder(int id, OrderDetail orderDetail)
        {
            var existing = repository.GetById(id);
            if (existing != null)
            {
                orderDetail.OrderId = existing.OrderId;
                orderDetailsData.EditOrderDetail(orderDetail);
            }
            return Ok();
        }


        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteOrderDetail(int id)
        {
            var order = repository.GetById(id);
            if (order != null)
            {
                repository.Delete(id);
                return Ok();
            }
            else
            {
                return NotFound("No order detail found");
            }
        }
    }
}
