using Microsoft.EntityFrameworkCore;

namespace StudentApi.DataModels
{
    public class SAContext:DbContext
    {
        public SAContext(DbContextOptions<SAContext> option):base(option)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Address> Address { get; set; }
    }
}
