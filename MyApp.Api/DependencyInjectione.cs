using MyApp.Application;
using MyApp.Infrastructure;

namespace MyApp.Api
{
    public static class DependencyInjectione
    {
        public static IServiceCollection AddAppDI(this IServiceCollection services)
        {
            services.AddApplicationDI()
            .AddInfarastructureDI();
            return services;
        }
    }
}
