using Domain.IRepository;
using Domain.IRepository.Base;
using Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;
namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IJobTypeRepository, JobTypeRepository>();
            return services;
        }
    }
}
