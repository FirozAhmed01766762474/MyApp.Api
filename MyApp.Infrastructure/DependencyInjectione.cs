using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Core.Interfaces;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repositories;

namespace MyApp.Infrastructure
{
    public static class DependencyInjectione
    {
        public static IServiceCollection AddInfarastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=OS-ZAHID\\SQLEXPRESS; Database=CleanArchDb; Trusted_Connection=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
            });

            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            return services;
        }

    }
}
