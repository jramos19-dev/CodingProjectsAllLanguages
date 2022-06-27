using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Packt.Shared;
using System.Buffers;

namespace NorthwindWeb
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // setting the connection string first
            string databasePath = Path.Combine("..", "Northwind.db");

            // telling the application what will be the database provider that is going to be used and pasing in the connection string
            services.AddDbContext<Northwind>(options => options.UseSqlite($"Data Source={databasePath}"));

            // this enables the services associated to razor pages like model binding, authorization antiforgery views and tag helpers
            services.AddRazorPages();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {


                app.UseDeveloperExceptionPage();
            }
            else
            {
                //enables the use of strict transport security forces communication of https, prevents user from using untrusted or invalid certificates.
                app.UseHsts();
            }

            app.UseRouting();
            //redircts http request to https
            app.UseHttpsRedirection();

            //adding these statements to allow static files and default files 
            // use default must always come first before use static files or the app wont work
            app.UseDefaultFiles(); // index.html,default.html and so on
            app.UseStaticFiles();

            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapGet("/", async context =>
                // {
                //     await context.Response.WriteAsync("Hello World!");
                // });
                endpoints.MapRazorPages();
            });
        }
    }
}
