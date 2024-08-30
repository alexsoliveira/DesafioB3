using Desafio.B3.Business.Interfaces;
using Desafio.B3.Business.Notificacoes;
using Desafio.B3.Business.Services;
using Desafio.B3.Business.Services.TabelaImposto;

namespace Desafio.B3.Api.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {           
            // Business
            services.AddScoped<ICdbService, CdbService>();            
            services.AddScoped<IImpostoService, ImpostoAte6MesesService>();
            services.AddScoped<IImpostoService, ImpostoDe7Ate12MesesService>();
            services.AddScoped<IImpostoService, ImpostoDe13Ate24MesesService>();
            services.AddScoped<IImpostoService, ImpostoAcimaDe24MesesService>();
            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}
