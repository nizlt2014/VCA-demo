using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserService.Application.Interfaces;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // DB / Repositories
        services.AddScoped<IUserService, UserService.Application.Services.UserService>();
        return services;
    }
}