using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using NajotNur.Domain.Entities;
using System.Security.Cryptography.X509Certificates;

namespace NajotNur.Infrastructure.AppDbContext;

public class AppDbContext:DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
    {
        var databaseCreator = Database.GetService<IDatabaseCreator>() as RelationalDatabaseCreator;

        if (databaseCreator != null)
        {
            if (!databaseCreator.CanConnect()) databaseCreator.Create();
            if (!databaseCreator.HasTables()) databaseCreator.CreateTables();
        }
       
    }
    public DbSet<User> Users { get; set; }
}
