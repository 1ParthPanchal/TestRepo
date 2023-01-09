using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pharm_Easy_Models;
using Pharm_Easy_Models.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pharm_Easy_Models.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        //Data db = new Data();
        private IRepository repository;
        public CategoriesController()
        {
            this.repository = new Repository(new Context());
        }
        //private ICategoriesService Services { get; set; }
        //public CategoriesController(IRepository repository)
        //{
        //    this.repository = repository;
        //}
        // GET: api/<CategoriesController>
        [HttpGet]
        [Route("GetCat")]
        public IActionResult GetCategories()
        {
            IEnumerable<Categories> categories = repository.GetCategories();
            return Ok(categories);
        }
        [HttpPost]
        [Route("PostCat")]
        public IActionResult Postinsertcategories(Categories categories)
        {

        }
        //[HttpGet]
        //[Route("GetCat")]
        //public async Task<IActionResult> Get()
        //{
        //    return Ok(await db.Get());
        //}
        //[HttpGet]
        //[Route("GetPro")]
        //public async Task<IActionResult> GetPro()
        //{
        //    return Ok(await db.GetPro());
        //}
        //[HttpPost]
        //[Route("PostCat")]
        //public async Task<IActionResult> Post([FromBody] Categories categories)
        //{
        //    try { } catch (Exception e) { }
        //    return Ok(await db.Post(categories));
        //}
        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoriesController>
        [HttpPost]
        [Route("Addcat")]
        //public IActionResult Post([FromBody] Categories categories)
        //{
        //    return Ok(Services.Add(categories));
        //}

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
