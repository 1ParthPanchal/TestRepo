using Microsoft.AspNetCore.Mvc;
using Dotenetcore_Demo;
using Dotenetcore_Demo.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Dotenetcore_Demo.Controllers
{
    [Route("api/")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        const string endpointSecret = "sk_test_51M3vmBSFlFitg6l1Ppe3KDaqkadcXInSxftXTV8yEu8TRGkZx0kUIrZL68cjxDNiPHGgMJixXpFwFfoGIGTa9V2g00RZKWzFBI";
        private readonly StudentService _student;


       // public object EventUtility { get; private set; }

        public StudentController(StudentService student)
        {
            _student = student;
        }

        [HttpGet]
        [Route("Get-Student")]
        public async Task<List<Student>> Get()
        {
            return await _student.GetAsync();
        }
        //[HttpGet]
        //[Route("Get-Strip")]
        //public async Task<List<Student>> GetA()
        //{
        //    return await _student.GetAsync();
        //}
        
        [HttpGet]
        [Route("Get-Student/{Id}")]
        public async Task<ActionResult<Student>> Get(String Id)
        {
            var student = await _student.GetAsync(Id);
            if (student is null)
            {
                return NotFound();
            }
            else
            {
                return student;
            }
        }

        /// <summary>
        /// This routine is used to get list of student based on pagination parameters.
        /// </summary>
        /// <param name="PageNumber"></param>
        /// <returns>List of Students</returns>
        /// <remarks>This is my test method</remarks>        
        [HttpGet]
        [Route("Get-Students/{PageNumber}")]
        public async Task<ActionResult<Student>> GetPage(Student stu)
        {
            var x = _student.GetAsyncPage(stu);

            //var x = PageNumber;
            //try
            //{
            //    var studentsss = await _student.GetAsyncPage(x);
            //    return studentsss;
            //}
            //catch(Exception e)
            //{ }
            return Ok(x);


        }
        [HttpPost]
        [Route("Add-Stripe")]
        public async Task<IActionResult> AddS(Student student)
        {
            await _student.AddAsync(student);
            return Ok(student);

        }
        [HttpPost]
        [Route("Add-StripeData")]
        public async Task<IActionResult> Index()
        {
            Console.WriteLine("Hello All");
            return Ok();
            //var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            try
            {
                //var stripeEvent = EventUtility.ConstructEvent(json,
                //    Request.Headers["Stripe-Signature"], endpointSecret);

                // Handle the event
                //Console.WriteLine("Unhandled event type: {0}", stripeEvent.Type);
                Console.WriteLine("Hello All");
                //return Ok();
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
        [HttpPost]
        [Route("Add-Student")]
        public async Task<IActionResult>  Add(Student student)
        {
            await _student.AddAsync(student);
            return Ok(student);
            
        }
        [HttpPut]
        [Route("Update-Student")]
        public async Task<IActionResult> Update(String Id,Student newStudent)
        {
            var Student = await _student.GetAsync(Id);
            if(Student is null)
            {
                return NoContent();
            }
            _student.UpdateAsync(Id, newStudent);
            return Ok(newStudent);
        }
        [HttpDelete]
        [Route("Delete-Student")]
        public async Task<IActionResult> Delete(String Id)
        {
            var Student = await _student.GetAsync(Id);
            if (Student is null)
            {
                return NotFound();
            }
            _student.removeAsync(Id);
            return Ok();
        }

        
    }
}
