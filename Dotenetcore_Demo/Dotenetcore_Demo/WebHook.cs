using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using Newtonsoft.Json;
using Stripe.Infrastructure;
using Stripe;
using Microsoft.Extensions.Options;
using Dotenetcore_Demo.Model;
using Dotenetcore_Demo;
using MongoDB.Driver;

namespace Dotenetcore_Demo.Controllers
{

    [Route("api/")]
    public class StripeWebHook : Controller
    {

        private readonly IConfiguration _configuration;
        private readonly ILogger _logger;
        public StripeWebHook(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        const string endpointSecret = "whsec_N3Fft16dd307GEPRLGWDGpZBolsfF7ek";

        [HttpPost]
        [Route("WebHook")]
        public async Task<IActionResult> Index()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();

            try
            {

                Console.WriteLine(Request.Headers);
                var stripeEvent = EventUtility.ConstructEvent(json,

                    Request.Headers["Stripe-Signature"], endpointSecret);

                // Handle the event
                if (stripeEvent.Type == Events.PaymentIntentSucceeded)
                {
                    var paymentIntent = stripeEvent.Data.Object as PaymentIntent;
                    Console.WriteLine("PaymentIntent was successful!");
                }
                else if (stripeEvent.Type == Events.PaymentMethodAttached)
                {
                    var paymentMethod = stripeEvent.Data.Object as PaymentMethod;
                    Console.WriteLine("PaymentMethod was attached to a Customer!");
                }
                //// ... handle other event types
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
    }
}
