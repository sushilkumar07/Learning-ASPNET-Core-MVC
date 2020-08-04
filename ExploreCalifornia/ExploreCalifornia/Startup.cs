using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ExploreCalifornia
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        /*Define the custom configration*/
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            /*Resolve the Dependancy Injection*/
            services.AddSingleton<FeatureToggles>(x => new FeatureToggles
            {
                DeveloperException = configuration.GetValue<bool>("EnableDeveloperExceptionPage")
            });
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,
            FeatureToggles featureToggles)
        {
            app.UseExceptionHandler("/error.html");
            /*This exception middleware used raised error then redirect to error page
             Change the ENV veriable then actual error page*/
            if (featureToggles.DeveloperException)
            {
                app.UseDeveloperExceptionPage();
            }

            //if (configuration.GetValue<bool>["EnableDeveloperExceptionPage"] == true)
            //{
            //    app.UseDeveloperExceptionPage();
            //}
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            /**Handled the exception handling*/
            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("invalid"))
                    throw new Exception("new throw Error..!!");

                await next();
            });
            /*Configure routes in core 2.0*/
            //app.UseMvc(routes =>
            //{
            //    routes.MapRoute("Default",
            //                    "{controller=Home}/{action=Index}/id");
            //});
            /*Configure routes in core 3.1*/
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            /*Middle Ware :Use contain from wwwroot folder Use file server or serve static files*/
            app.UseFileServer();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        if (context.Request.Path.Value.StartsWith("/hello"))
            //        {
            //            await context.Response.WriteAsync("Hello asp.net core World!");
            //        }
            //        else
            //        {
            //            await context.Response.WriteAsync("Hello asp.net core World!22");
            //        }

            //    });
            //});

        }
    }
}
