using Microsoft.Extensions.DependencyInjection;
using School_Infrastracture.Abstract;
using School_Infrastracture.Infrastracture_Bases;
using School_Infrastracture.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Infrastracture
{
    public static class Modul_Infrastracture_Dependencess
    {
        public static IServiceCollection AddInfrastractureDependencess(this IServiceCollection services)
        {

            services.AddTransient<IStudentRepo, StudentRepo>();
            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));


            return services;


        }
    }
}
