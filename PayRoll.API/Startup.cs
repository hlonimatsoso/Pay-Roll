using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using PayRoll.API.Services;
using PayRoll.Data;
using PayRoll.Data.Repos;
using PayRoll.Interfaces;
using PayRoll.Models;

namespace PayRoll.API
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
            services.AddControllers();
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<PayRollDBContext>(options =>
               options.UseMySql(connectionString)
           );

            services.AddTransient(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient(typeof(IBaseSevice<>), typeof(BaseSevice<>));
            services.AddTransient<ITaskRepo, TaskRepo>();
            services.AddTransient<IEmployeeTask, EmployeeTask>();
            services.AddTransient<IRoleLevel, RoleLevel>();
            services.AddTransient<ITaskService, TaskService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Pay Roll API",
                    Description = "Pay Roll + ASP.NET Core Web API = LOVE",
                    TermsOfService = new Uri("https://hlonimatsoso.com/terms"),
                    Contact = new OpenApiContact
                    {
                        Name = "Hloni Matsoso",
                        Email = "hloni2010@gmail.com",
                        Url = new Uri("https://twitter.com/@matsosoWTF"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://hlonimatsoso.com/license"),
                    }
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Pay Roll API v1");
            });

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
        }
    }
}
