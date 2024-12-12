using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace MyApp.Core
{
    public static class DependencyInjectione
    {
        public static IServiceCollection AddCoreDI(this IServiceCollection services)
        {
            return services;
        }

    }
}
