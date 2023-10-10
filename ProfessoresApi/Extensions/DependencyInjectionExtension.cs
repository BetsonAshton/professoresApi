using ProfessoresApi.Application.Interfaces;
using ProfessoresApi.Application.Services;
using ProfessoresApi.Domain.Interfaces.Repositories;
using ProfessoresApi.Domain.Interfaces.Services;
using ProfessoresApi.Domain.Services;
using ProfessoresApi.Infra.Data.Repositories;

namespace ProfessoresApi.Extensions
{
    public static class DependencyInjectionExtension
    {

        public static IServiceCollection AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IProfessoresAppService, ProfessoresAppService>();
            services.AddTransient<IProfessoresDomainService, ProfessoresDomainService>();
            services.AddTransient<IProfessoresRepository, ProfessoresRepository>();


            return services;
        }

    }
}
