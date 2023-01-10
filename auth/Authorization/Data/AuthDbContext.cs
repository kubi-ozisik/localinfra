using IdentityServer4.EntityFramework.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Authorization.Data
{
    public class AuthDbContext : IdentityDbContext
    {
        public AuthDbContext()
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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
            : base(options)
        {

        }
    }
}
