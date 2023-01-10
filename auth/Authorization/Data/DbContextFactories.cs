using IdentityServer4.EntityFramework.DbContexts;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Authorization.Data
{
    //public class ConfigurationContextDesignTimeFactory : IDesignTimeDbContextFactory<ConfigurationDbContext>
    //{
    //    public ConfigurationDbContext CreateDbContext(string[] args)
    //    {
    //        var builder = WebApplication.CreateBuilder(args);
    //        var configuration = builder.Configuration;
    //        configuration.SetBasePath(Directory.GetCurrentDirectory());
    //        configuration.AddJsonFile("appsettings.json");

    //        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    //        var dbContextOptionsBuilder = new DbContextOptionsBuilder<ConfigurationDbContext>();
    //        dbContextOptionsBuilder.UseSqlServer(connectionString);
    //        return new ConfigurationDbContext(dbContextOptionsBuilder.Options, null);
    //    }
    //}

    //public class PersistedGrantDbContextDesignTimeFactory : IDesignTimeDbContextFactory<PersistedGrantDbContext>
    //{
    //    public PersistedGrantDbContext CreateDbContext(string[] args)
    //    {
    //        var builder = WebApplication.CreateBuilder(args);
    //        var configuration = builder.Configuration;
    //        configuration.SetBasePath(Directory.GetCurrentDirectory());
    //        configuration.AddJsonFile("appsettings.json");

    //        var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    //        var dbContextOptionsBuilder = new DbContextOptionsBuilder<PersistedGrantDbContext>();
    //        dbContextOptionsBuilder.UseSqlServer(connectionString);
    //        return new PersistedGrantDbContext(dbContextOptionsBuilder.Options, null);
    //    }
    //}
}
