using EmployeeManager.Business.Interfaces;
using EmployeeManager.Business.Services;
using EmployeeManager.Data.Repository;

namespace EmployeeManager.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static void ConfigureDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IJobOpportunityService, JobOpportunityService>();
            services.AddScoped<IAddressService, AddressService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IJobOpportunityRepository, JobOpportunityRepository>();
        }
    }
}
