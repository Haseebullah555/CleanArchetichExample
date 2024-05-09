using Application.Contracts.Interfaces;
using Infrastructure.Contracts.Implementations;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;
using System.Reflection;

namespace CleanArcheticExample.StartUpExtension
{
    public static class ConfigurationServices
    {
        public static IServiceCollection ApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
