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
    public class ProductController : ControllerBase
    {
        private readonly IGenericRepository<Product> repository;
        private readonly IProductData productData;

        public ProductController(IGenericRepository<Product> repository, IProductData productData)
        {
            this.repository = repository;
            this.productData = productData;
        }


        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetProducts()
        {
            return Ok(repository.GetAll());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetProduct(int id)
        {
            return Ok(repository.GetById(id));
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddProduct(Product product)
        {
            repository.Insert(product);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                product.ProductId, product);
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditProduct(int id, Product product)
        {
            var existing = repository.GetById(id);
            if (existing != null)
            {
                product.ProductId = existing.ProductId;
                productData.EditProduct(product);
            }
            return Ok();
        }


        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = repository.GetById(id);
            if (product != null)
            {
                repository.Delete(id);
                return Ok();
            }
            else
            {
                return NotFound("No Product found");
            }
        }
    }
}
