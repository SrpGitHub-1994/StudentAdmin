using StudentApi.DataModels;
using System.Collections.Generic;

namespace StudentApi.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
    }
}
