using Microsoft.AspNetCore.Mvc;
using StudentApi.Repository;
using System.Threading.Tasks;

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
        public async Task<IActionResult> GetAllStudent()
        {
            var StdList = await studentrepository.GetStudents();
            return Ok(StdList);
        }
    }
}
