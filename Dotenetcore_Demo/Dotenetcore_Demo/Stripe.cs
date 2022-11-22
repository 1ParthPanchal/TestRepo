using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Stripe;
using Dotenetcore_Demo.Model;
using MongoDB.Driver;
using System;
using System.IO;

//try
//{
    //StripeConfiguration.ApiKey = "sk_test_51M3vmBSFlFitg6l1Ppe3KDaqkadcXInSxftXTV8yEu8TRGkZx0kUIrZL68cjxDNiPHGgMJixXpFwFfoGIGTa9V2g00RZKWzFBI";
//}
//catch(Exception e)
//{
//    return BadRequest();
//}



// Since C# is strongly typed,
// the version is fixed in the library.
//using System;
//using System.IO;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Stripe;


namespace Dotenetcore_Demo
{
    public class DemoService
    {
        private readonly IMongoCollection <DatabaseSetting> _database;
        public DemoService(IOptions<DatabaseSetting> dataa)
        {
            var x = new MongoClient(dataa.Value.ConnectionString);
         var y= dataa.Value.StripeApiKey;
        }

       
    }
    [Route("api/[controller]")]
    public class StripeWebHook : Controller
    {
        

        public IConfiguration _configuration;
        private readonly DemoService _demoService;
        // If you are testing your webhook locally with the Stripe CLI you
        // can find the endpoint's secret by running `stripe listen`
        // Otherwise, find your endpoint's secret in your webhook settings
        // in the Developer Dashboard

        public StripeWebHook(DemoService demoService, IConfiguration configuration)
        {
            _demoService = demoService;
            _configuration = configuration;
        }
        [HttpPost]
        [Route("Customer")]
        public async Task<IActionResult> WebHook()
        {
        


            try
            {
                var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
                Console.WriteLine(HttpContext.Request.Body);


                var endpointSecret = "whsec_2dfcabd772fdb1710b48178a11d5e843449c130eca25d953087b1bbe47c0c58e";


                var signatureHeader = Request.Headers["Stripe-Signature"];
                Console.WriteLine(signatureHeader);

                var stripeEvent = EventUtility.ConstructEvent(json,
                  signatureHeader, endpointSecret);
                Console.WriteLine(stripeEvent);


                // Handle the event
                if (stripeEvent.Type == Events.CustomerCreated)
                {
                }
                // ... handle other event types
                else
                {
                    Console.WriteLine("Unhandled event type: {0}", stripeEvent.Type);
                }

                return Ok();
            }
            catch (StripeException)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("Invoice-created")]
        public async Task<IActionResult> Index()
        {
       
            try
            {
                var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
                Console.WriteLine(HttpContext.Request.Body);
                var endpointSecret = "whsec_2dfcabd772fdb1710b48178a11d5e843449c130eca25d953087b1bbe47c0c58e";
                var signatureHeader = Request.Headers["Stripe-Signature"];
                Console.WriteLine(signatureHeader);
                var stripeEvent = EventUtility.ConstructEvent(json,
                    Request.Headers["Stripe-Signature"], endpointSecret);

                // Handle the event
                if (stripeEvent.Type == Events.InvoiceCreated)
                {
                }
                // ... handle other event types
                else
                {
                    Console.WriteLine("Unhandled event type: {0}", stripeEvent.Type);
                }

                return Ok();
            }
            catch (StripeException e)
            {
                return BadRequest();
            }
        }
    }
}
