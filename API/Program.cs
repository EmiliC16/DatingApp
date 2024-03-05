//using API.Data;
//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
//using Microsoft.EntityFrameworkCore;
using System.Text;
using API.Data;
using API.Extentions;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();

// Configure the H0TTP request pipeline.
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod()
        .WithOrigins("http://localhost:4200"));

        app.UseAuthentication();
        app.UseAuthorization();

app.MapControllers();

app.Run();
