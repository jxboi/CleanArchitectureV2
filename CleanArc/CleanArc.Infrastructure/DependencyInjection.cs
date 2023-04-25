using CleanArc.Application.Common.Interfaces.Authentication;
using CleanArc.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArc.Infrastructure; 

 public static class DependencyInjection
 {
     public static IServiceCollection AddInfrastructure(this IServiceCollection services)
     {
        services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
        return services;
     }
 }