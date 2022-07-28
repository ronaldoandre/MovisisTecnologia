using Microsoft.Extensions.DependencyInjection;
using MovisisTecnologia.Domain.Interfaces.Services;
using MovisisTecnologia.Service.Services;

namespace MovisisTecnologia.CrossCutting.DependencyInjection;
public class ConfigureService
{
    public static void ConfigureDependenciesService(IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IClienteService, ClienteService>();
        serviceCollection.AddScoped<ICidadeService, CidadeService>();
    }
}
