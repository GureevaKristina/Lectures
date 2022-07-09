//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
namespace Lecture3
{
    public class ProgramContext : DbContext
    {
        public ProgramContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        //services.AddDbContext<AspDbContext>(options =>
       // options.UseSqlServer(config.GetConnectionString("optimumDB")));
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"data source=(LocalDb)\MSSQLLocalDB;Initial Catalog=personsstore;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(modelBuilder: builder);
        }
    }
}
