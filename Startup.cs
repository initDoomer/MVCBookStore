using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllersWithViews(); // enable mvc design pattern into our .netcore app

            // use preprocessor directive for setting a condition. DEBUG: will work only in the development environment
#if DEBUG
            services.AddRazorPages().AddRazorRuntimeCompilation(); // enable runtime compilation
#endif
        }




        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // inserts this middleware
            }


            /*app.Use(async (context, next) =>
            {

                await context.Response.WriteAsync("This is a middleware");
                await next(); // passes control to the next middleware n the pipeline                
            });*/

            app.UseStaticFiles(); // required to use static files
            app.UseRouting(); // maps the url to a particular resource, ie. enable routing

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapDefaultControllerRoute(); // default route {controller=Home}/{action=Index}/{id?}
                endpoints.MapControllerRoute(
                    name: "Default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                    );
            });

          
        }
    }
}
