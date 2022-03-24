using StudentApi.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentApi.Repository
{
    public interface IStudentRepository
    {
       Task<List<Student>> GetStudents();
    }
}
