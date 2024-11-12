
using Microsoft.EntityFrameworkCore;
using School_Infrastracture;
using School_Infrastracture.Abstract;
using School_Infrastracture.Data;
using School_Infrastracture.Repository;
using School_Service;

namespace School_Management
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationDBContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("dbcontextclean")));

            #region Registers

            builder.Services.AddInfrastractureDependencess()
                .AddServiceDependencess();

            #endregion




            var app = builder.Build();


            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
