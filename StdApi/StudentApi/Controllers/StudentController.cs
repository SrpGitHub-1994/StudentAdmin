using Microsoft.AspNetCore.Mvc;
using StudentApi.Repository;

namespace StudentApi.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentrepository;

        public StudentController(IStudentRepository studentrepository)
        {
            this.studentrepository = studentrepository;
        }
        [HttpGet]
        [Route("[controller]")]
        public IActionResult GetAllStudent()
        {
            return Ok(studentrepository.GetStudents());
        }
    }
}
