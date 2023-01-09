using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pharm_Easy_Models.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pharm_Easy_Models.Controllers
{
    [Route("api/Offers")]
    [ApiController]
    public class OffersController : ControllerBase
    {
        public IOffersService Offers;
        public OffersController(IOffersService Offers)
        {
            this.Offers = Offers;
        }
        [HttpGet]
        [Route("GetOffers")]
        public async Task<List<Offers>> GetOffers()
        {
            return await Offers.GetOffers();
        }
        [HttpPost]
        [Route("PostOffers")]
       public IActionResult insertoffers(Offers offers)
        {
            Offers.insertoffers(offers);
            return Ok(offers);
        }
    }
}
