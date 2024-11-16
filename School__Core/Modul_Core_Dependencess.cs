using Microsoft.Extensions.DependencyInjection;
using School_Service.Abstract;
using School_Service.Repository;
using System.Reflection;

namespace School__Core
{
    public static class Modul_Core_Dependencess
    {
        public static IServiceCollection AddCoreDependencess(this IServiceCollection services)
        {

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            return services;


        }
    }
}
