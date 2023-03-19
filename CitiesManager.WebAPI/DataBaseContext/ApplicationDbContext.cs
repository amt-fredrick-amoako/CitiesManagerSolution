using CitiesManager.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesManager.WebAPI.DataBaseContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public ApplicationDbContext()
        {}

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(new City
            {
                CityID =
            });
        }

    }
}
