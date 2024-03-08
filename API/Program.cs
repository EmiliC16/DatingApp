//using API.Data;
//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
//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using API.Extentions;
using API.Middleware;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();
app.UseMiddleware<ExceptionMiddleware>();
// Configure the H0TTP request pipeline.
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod()
        .WithOrigins("https://localhost:4200"));

        app.UseAuthentication();
        app.UseAuthorization();

app.MapControllers();

app.Run();
