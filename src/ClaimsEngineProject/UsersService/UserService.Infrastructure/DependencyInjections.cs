// ClaimsService.Infrastructure/DependencyInjection.cs
using UserService.Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using UserService.Infrastructure.Repositories;

namespace UserService.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration config)
    {
        // DB / Repositories
        services.AddScoped<IUserRepository, UserRepository>();
        return services;
    }
}
