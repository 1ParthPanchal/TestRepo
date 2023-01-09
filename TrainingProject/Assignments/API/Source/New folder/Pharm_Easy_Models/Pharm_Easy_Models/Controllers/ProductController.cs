using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pharm_Easy_Models.Models;
using Pharm_Easy_Models.Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pharm_Easy_Models.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductService Product;
        public ProductController(IProductService Product)
        {
            this.Product = Product;
        }
        // GET: api/<ProductController>
        [HttpGet]
        [Route("GetProduct")]
        public async Task<List<Product>> GetProducts()
        {
            return await Product.GetProducts();
        }

        public IActionResult insertproducts(Product product)
        {
            Product.insertproducts(product);
            return Ok(product);
        }
    }
}
