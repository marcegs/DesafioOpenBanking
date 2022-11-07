using System;
using System.Text;
using Application.Common.Models;
using Application.Interfaces;
using Infra.Authentication;
using Infra.Authentication.Models;
using Infra.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddInfra(this IServiceCollection services, IConfiguration configuration)
    {
        var key = Encoding.ASCII.GetBytes(configuration["JwtSettings:SecretKey"]);

        services.Configure<JwtSettings>(configuration.GetSection("JwtSettings"));
        
        services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(x =>
        {
            x.RequireHttpsMetadata = false;
            x.SaveToken = true;
            x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false
            };
        });
        services.AddAuthorization(options =>
        {
            options.AddPolicy("User", policy => policy.RequireRole("User"));
        });
        
        services.AddHttpClient("OpenBanking",
            client => { client.BaseAddress = new Uri(configuration["OpenBankingUri"]); });
        services.AddScoped<IOpenBankingServices, OpenBankingServices>();
        services.AddScoped<IApplicationUserServices, ApplicationUserServices>();
        services.AddDbContext<ApplicationIdentityDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("Identity")));
        services.AddIdentity<ApplicationUser, IdentityRole>().AddEntityFrameworkStores<ApplicationIdentityDbContext>();
        
        return services;
    }
}