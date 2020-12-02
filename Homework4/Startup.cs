using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Homework4.Common.Swagger;
using Homework4.Services.Bootstrap;
using Homework4.Services.Services;
using AutoMapper;
using System.Reflection;
using Homework4.DAL.Bootstrap;
using Homework4.Repositories;
using Homework4.Controllers;
using Homework4.Repositories.Bootstrap;

namespace Homework4
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }        
        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureDb(Configuration);
            services.ConfigureRepositories();
            services.AddControllers();
            services.ConfigureServices();
          
            services.AddAutoMapper(
                 typeof(BuildingRepository).GetTypeInfo().Assembly,
                 typeof(BuildingController).GetTypeInfo().Assembly,
                 typeof(ConstructionCompanyRepository).GetTypeInfo().Assembly,
                 typeof(ConstructionCompanyController).GetTypeInfo().Assembly
             );
            services.ConfigureSwagger();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.UseCors();
            app.UseOpenApi();
            app.UseSwaggerUi3();            
        }
    }
}
