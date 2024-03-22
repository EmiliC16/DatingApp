using API.Data;
using API.Errors;
using API.Extensions;

//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
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddIdentityServices(builder.Configuration);

var app = builder.Build();
// Configure the H0TTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().AllowCredentials()
        .WithOrigins("https://localhost:4200"));

app.UseAuthentication(); //first line should be
app.UseAuthorization(); //second line should be



app.MapControllers();
using var scope= app.Services.CreateScope();
var services=scope.ServiceProvider;
try{
        var context=services.GetRequiredService<DataContext>();
        await context.Database.MigrateAsync();
        await Seed.SeedUsers(context);

}
catch(Exception ex){
        var logger=services.GetService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while migrating");
}

app.Run();
