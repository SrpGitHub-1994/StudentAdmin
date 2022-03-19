using Microsoft.EntityFrameworkCore;

namespace StudentApi.DataModels
{
    public class SAContext:DbContext
    {
        public SAContext(DbContextOptions<SAContext> option):base(option)
        {

        }

        DbSet<Student> Students { get; set; }
        DbSet<Gender> Genders { get; set; }
        DbSet<Address> Address { get; set; }
    }
}
