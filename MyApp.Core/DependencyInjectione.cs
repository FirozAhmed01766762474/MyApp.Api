using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Options;

namespace MyApp.Core
{
    public static class DependencyInjectione
    {
        public static IServiceCollection AddCoreDI(this IServiceCollection services, IConfiguration configaration)
        {

            services.Configure<ConnectionStringOptions>(configaration.GetSection(ConnectionStringOptions.SectionName));

            return services;
        }

    }
}
