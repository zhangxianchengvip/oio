using Microsoft.Extensions.DependencyInjection;
using System;

namespace oio.Core
{
    public static class OioCoreServiceExtensions
    {
        public static IServiceCollection AddOioCore(this IServiceCollection services)
        {
            return services;
        }
    }
}
