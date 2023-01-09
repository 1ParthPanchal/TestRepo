using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pharmEasy.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pharmEasy.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private IRepository repository;
        public CategoryController()
        {
            this.repository = new Repository(new pharmeasy2443parthContext());
        }
        // GET: api/<CategoryController>
        [HttpGet]
        [Route("GetCat")]
        public IActionResult GetCategories()
        {
            IEnumerable<Category> categories = repository.GetCategories();
            return Ok(categories);
        }
        [HttpPost]
        [Route("PostCat")]
        public ActionResult insertcategories(Category categories)
        {
            repository.insertcategories(categories);
            return Ok(categories);
        }

        //// GET api/<CategoryController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<CategoryController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<CategoryController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CategoryController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
