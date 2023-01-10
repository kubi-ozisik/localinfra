using Authorization;
using Authorization.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var defaultConfigurationString = builder.Configuration.GetConnectionString("DefaultConnection");

var assembly = typeof(Program).Assembly.GetName().Name;

builder.Services
    .AddDbContext<AuthDbContext>(options => options.UseSqlServer(defaultConfigurationString,
        b => b.MigrationsAssembly(assembly)));
builder.Services
    .AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AuthDbContext>();

builder.Services
    .AddIdentityServer()
    .AddAspNetIdentity<IdentityUser>()
    .AddConfigurationStore(options =>
    {
        options.ConfigureDbContext = dbContext =>
        {
            dbContext.UseSqlServer(defaultConfigurationString, opt => opt.MigrationsAssembly(assembly));
        };
    })
    .AddOperationalStore(options =>
    {
        options.ConfigureDbContext = dbContext =>
        {
            dbContext.UseSqlServer(defaultConfigurationString, opt => opt.MigrationsAssembly(assembly));
        };
    })
    .AddDeveloperSigningCredential();

builder.Services.AddControllersWithViews();



var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});
app.Run();
