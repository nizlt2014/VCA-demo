using ClaimsService.Infrastructure.Interfaces;
using ClaimsService.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ClaimsService.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            // Example: Add DB connection factory if needed
            services.AddScoped<IClaimRepository, ClaimRepository>();

            return services;
        }
    }

}
