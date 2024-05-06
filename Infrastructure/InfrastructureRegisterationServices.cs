using Application.Contracts.Interfaces;
using Infrastructure.Contracts.Implementations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Persistence
{
    public static class InfrastructureRegisterationServices
    {
        public static IServiceCollection AddInfrastructure  (this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
