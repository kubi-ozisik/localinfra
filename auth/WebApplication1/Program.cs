using API.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddAuthentication("Bearer")
        .AddIdentityServerAuthentication("Bearer", options =>
        {
            options.Authority = "https://localhost:5000";
            options.ApiName = "API";
        });

builder.Services.AddScoped<ISampleResourceService, SampleResourceService>();


var app = builder.Build();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

app.Run();
