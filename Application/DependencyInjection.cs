using Application.IService;
using Application.Service;
using Infrastructure;
using Microsoft.Extensions.DependencyInjection;

using System.Reflection;

namespace Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IJobTypeService, JobTypeService>();
            services.AddInfrastructureServices();
          
            
            return services;
        }
    }
}