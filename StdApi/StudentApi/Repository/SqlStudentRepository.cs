using StudentApi.DataModels;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace StudentApi.Repository
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly SAContext context;

        public SqlStudentRepository(SAContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudents()
        {
            return await context.Students               
                .Include(nameof(Address))
                .Include(nameof(Gender))
                .ToListAsync();
        }
    }
}
