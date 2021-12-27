using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MIddleWarePractice
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
            services.AddTransient<CustomMiddleware>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.Use(async (context,next) => {
                await context.Response.WriteAsync("Response from First Middleware\n");
                await next();
                await context.Response.WriteAsync("Use Middleware1 Outgoing Response \n");
            });
            app.Use(async (context,next) => {
                await context.Response.WriteAsync("Response from Second Middleware\n");
                await next();
                await context.Response.WriteAsync("Use Middleware2 Outgoing Response \n");
            });
            app.UseMiddleware<CustomMiddleware>();
            app.Map("/testmap", MapCustomMiddleware);

            app.Run(async context =>
            {
                await context.Response.WriteAsync("Response from Third MiddleWare\n");
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
        private void MapCustomMiddleware(IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Specific URL Logic Middleware using Map Method\n");

            });
        }
    }
}
