using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            var splitStringConverter = new ValueConverter<IEnumerable<string>, string>(v => string.Join(";", v), v => v.Split(new[] { ';' }));
            builder.Entity<MenuItem>()
                   .Property(nameof(MenuItem.Ingredients))
                   .HasConversion(splitStringConverter);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
        public DbSet<Basket> Baskets{ get; set; }
        public DbSet<Guest> Guests{ get; set; }
        public DbSet<Menu> Menus{ get; set; }
        public DbSet<MenuItem> MenuItems{ get; set; }
    }
}
