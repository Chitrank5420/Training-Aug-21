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
    public class CategoriesController : ControllerBase
    {
        private readonly IGenericRepository<Category> repository;
        private readonly ICategoryData categoryData;
        public CategoriesController(IGenericRepository<Category> repository,ICategoryData categoryData)
        {
            this.repository = repository;
            this.categoryData = categoryData;
        }

        [Route("api/[controller]")]
        [HttpGet]
        public IActionResult GetCategories()
        {
            return Ok(repository.GetAll());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetCategory(int id)
        {
            return Ok(repository.GetById(id));
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddCategory(Category category)
        {
            repository.Insert(category);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + "/" +
                category.CategoryId, category);
        }

        [HttpPatch]
        [Route("api/[controller]/{id}")]
        public IActionResult EditCategory(int id,Category category)
        {
            var existingCategory = repository.GetById(id);
            if(existingCategory != null)
            {
                category.CategoryId = existingCategory.CategoryId;
                categoryData.EditCategory(category);
            }
            return Ok();
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = repository.GetById(id);
            if (category != null)
            {
                repository.Delete(id);
                return Ok();
            }
            else
            {
                return NotFound("No User found");
            }
        }
    }
}
