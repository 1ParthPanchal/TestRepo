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
    [Route("api/CArticle")]
    [ApiController]
    public class CArticleController : ControllerBase
    {
        public ICArticleService CArticle;
        public CArticleController(ICArticleService CArticle)
        {
            this.CArticle = CArticle;
        }
       
        [HttpGet]
        [Route("GetCArticle")]
        public async Task<List<CArticle>> GetCarticle()
        {
            return await CArticle.GetCarticle();
        }
        [HttpPost]
        [Route("PostCArticle")]
        public IActionResult insertCarticle(CArticle cArticle)
        {
            CArticle.insertCarticle(cArticle);
            return Ok(cArticle);
        }
    }
}
