using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using School__Core.Behaviors;
using System.Reflection;

namespace School__Core
{
    public static class Modul_Core_Dependencess
    {
        public static IServiceCollection AddCoreDependencess(this IServiceCollection services)
        {

            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Get Validators
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            // 
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ValidationBehavior<,>));

            return services;

        }
    }
}
