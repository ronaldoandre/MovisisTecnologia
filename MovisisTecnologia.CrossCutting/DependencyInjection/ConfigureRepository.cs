using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovisisTecnologia.Data.Context;
using MovisisTecnologia.Data.Repository;
using MovisisTecnologia.Domain.Interfaces.Repository;
using MovisisTecnologia.Domain.Models;

namespace MovisisTecnologia.CrossCutting.DependencyInjection;

public class ConfigureRepository
{
    public static void ConfigureDependenciesRepository (IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IClienteRepository, ClienteRepository>();
        serviceCollection.AddScoped<ICidadeRepository, CidadeRepository>();

        serviceCollection.AddDbContext<MovisisTecnologiaContext>(
            options => options.UseSqlServer("Server=localhost;Database=movisisDB;Trusted_Connection=True;")
            );
    }
}