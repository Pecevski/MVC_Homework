﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using ToDo.Api.Services;
using ToDo.Api.Services.Interfaces;

namespace ToDo.Api.App
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
            //Connection string
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            //Data access dependencies
            DiModule.RegisterModule(services, connectionString);

            //Services 
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IToDoTaskService, ToDoTaskService>();
            services.AddTransient<IToDoSubTaskService, ToDoSubTaskService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "V 1.0";
                    document.Info.Title = "TODO Api";
                    document.Info.Description = "First TODO Api";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "ILija Pecevski",
                        Email = "ilija.pecevski@gmail.com"
                    };
                };
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseOpenApi();
            app.UseSwaggerUi3();

            app.UseMvc();
        }
    }
}
