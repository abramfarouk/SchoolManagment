using Microsoft.Extensions.DependencyInjection;
using SchoolManagment.Infrastructure.Abstracts;
using SchoolManagment.Infrastructure.InfrastructureBases;
using SchoolManagment.Infrastructure.Repository;


namespace SchoolManagment.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {

        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {

            services.AddTransient<IStudentRepository, StudentRepository>();
            services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));


            return services;
        }
    }
}
