using Microsoft.EntityFrameworkCore;
using NajotNur.Infrastructure.AppDbContext;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var dbHost = Environment.GetEnvironmentVariable("DB_HOST");
var dbName = Environment.GetEnvironmentVariable("DB_NAME");
var dbPassword = Environment.GetEnvironmentVariable("DB_SA_PASSWORD");

var connectionsString = $"Data Source= {dbHost};Initial Catalog={dbName};User ID=sa;Password={dbPassword}";



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(connectionsString);
});


var app = builder.Build();



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
