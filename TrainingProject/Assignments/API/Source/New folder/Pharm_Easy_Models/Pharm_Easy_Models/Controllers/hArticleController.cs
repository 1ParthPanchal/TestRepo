using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pharm_Easy_Models.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pharm_Easy_Models.Controllers
{
    [Route("api/hArticle")]
    [ApiController]
    public class hArticleController : ControllerBase
    {
        public IhArticleService hArticle;
        public hArticleController(IhArticleService hArticle)
        {
            this.hArticle = hArticle;
        }
        [HttpGet]
        [Route("GethArticle")]
        public async Task<List<hArticle>> GetHarticle()
        {
            return await hArticle.GetHarticle();
        }
        [HttpPost]
        [Route("PosthArticle")]
        public IActionResult insertHarticle(hArticle harticle)
        {
            hArticle.insertHarticle(harticle);
            return Ok(harticle);
        }
    }
}
