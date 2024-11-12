using Microsoft.Extensions.DependencyInjection;
using School_Infrastracture.Abstract;
using School_Infrastracture.Repository;
using School_Service.Abstract;
using School_Service.Repository;

namespace School_Service
{
    public  static class Modul_Service_Dependencess
    {
        public static IServiceCollection AddServiceDependencess(this IServiceCollection services)
        {

            services.AddTransient<IStudentService, StudentService>();
            return services;


        }
    }
}
