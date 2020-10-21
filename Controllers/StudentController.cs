using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using smsapi.Data;
using smsapi.Model;
using System;

namespace smsapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IRepository<Student> _repository;
        public StudentController(IRepository<Student> repository)
        {
            _repository = repository;
        }
        [HttpGet("getAllStudents")]
        public async Task<IActionResult> GetStudents()
        {
            var model = await _repository.GetData();
           va result-new List<StudentDto>();
           
        }
        [HttpGet("redirecttogoogle")]
        public IActionResult RedirectResult()
        {
            return Redirect("https://tomchentw.github.io/react-google-maps/`2");
        }
        [HttpGet("localRedirect")]
        public IActionResult LocalRedirect()
        {
            return LocalRedirect("/student/getAllStudents");
        }
        [HttpGet("getOk")]
        public IActionResult GetOkResult()
        {
            return Ok();
        }
        [HttpGet("getCreated")]
        public IActionResult GetCreatedResult()
        {
            return Created("http://yayobe.com/myitem",new {name="yared"});
        }
        [HttpGet("noContent")]
        public IActionResult NoContentResult()
        {
            return NoContent();
        }
        [HttpGet("badRequest")]
        public IActionResult BadRequestResult()
        {
            return BadRequest();
        }
        [HttpGet("unAutorized")]
        public IActionResult UnAutorizedResult()
        {
            return Unauthorized();
        }
        [HttpGet("okObjectResult")]
        public IActionResult okObjectResult(){
            var student = new ObjectResult( new {
                fName="yared",
                lName="solomon",
                Age=54
            });
             return student;

        }
        [HttpGet("getObjectStatusCodeRequest/{statusCode}")]
        public IActionResult ObjectResultWithStatus(int statusCode)
        {
            var result = new ObjectResult(new {
                statusCode=statusCode,
                currentDate=DateTime.Now
            });
            result.StatusCode=statusCode;
            return result;
        }
       

        
        
    }
}