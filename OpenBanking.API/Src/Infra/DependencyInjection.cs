using System;
using Application.Interfaces;
using Infra.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddInfra(this IServiceCollection services)
    {
        services.AddHttpClient("OpenBanking",
            client => { client.BaseAddress = new Uri("https://data.directory.openbankingbrasil.org.br/"); });
        services.AddScoped<IOpenBankingServices, OpenBankingServices>();
        return services;
    }
}