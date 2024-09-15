using Microsoft.Extensions.DependencyInjection;
using SchoolManagment.Services.Abstracts;
using SchoolManagment.Services.Implemetation;

namespace SchoolManagment.Services
{
    public static class ModuleServicesDependencies
    {
        public static IServiceCollection AddServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient<IStudentServices, StudentServices>();
            return services;

        }
    }
}
