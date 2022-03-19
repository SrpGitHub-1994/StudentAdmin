using StudentApi.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace StudentApi.Repository
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly SAContext context;

        public SqlStudentRepository(SAContext context)
        {
            this.context = context;
        }
        public List<Student> GetStudents()
        {
           return context.Students.ToList();
        }
    }
}
