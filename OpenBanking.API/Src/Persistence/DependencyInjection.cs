using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<OpenBankingDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("connString")));

        services.AddScoped<IOpenBankingDbContext>(provider => provider.GetService<OpenBankingDbContext>());

        return services;
    }
}