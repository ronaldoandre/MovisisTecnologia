using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MovisisTecnologia.Data.Context;
public class ContextFactory : IDesignTimeDbContextFactory<MovisisTecnologiaContext>
{
    public MovisisTecnologiaContext CreateDbContext(string[] args){
        var connectionString = "Server=localhost;Database=movisisDB;Trusted_Connection=True;";
        var optionsBuilder = new DbContextOptionsBuilder<MovisisTecnologiaContext>();
        optionsBuilder.UseSqlServer (connectionString);
        return new MovisisTecnologiaContext(optionsBuilder.Options);
    }
}