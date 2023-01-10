using Auth.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Auth.Data
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var sqlConnectionString = "Server=localhost,1433;Database=IDS;UID=sa;Password=Local1234";
            if (!options.IsConfigured)
            {
                options.UseSqlServer(sqlConnectionString);
            }
        }

        public SampleDbContext(DbContextOptions<SampleDbContext> options)
            : base(options)
        {

        }

        public DbSet<CoffeeShop> CoffeeShops { get; set; }
    }
}