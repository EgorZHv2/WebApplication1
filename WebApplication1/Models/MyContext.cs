using Microsoft.EntityFrameworkCore;
namespace WebApplication1.Models
{
    public class MyContext : DbContext
    {

        public DbSet<Person> Persons { get; set; }
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
