using ClaimsService.Application.Abstraction;
using ClaimsService.Application.Implementation;
using Microsoft.Extensions.DependencyInjection;
namespace ClaimsService.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IClaimsService, ClaimService>();
            return services;
        }
    }
}
