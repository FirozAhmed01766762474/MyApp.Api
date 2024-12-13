using MyApp.Application;
using MyApp.Core;
using MyApp.Infrastructure;

namespace MyApp.Api
{
    public static class DependencyInjectione
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddApplicationDI()
            .AddInfarastructureDI()
            .AddCoreDI(configuration);
            return services;
        }
    }
}
