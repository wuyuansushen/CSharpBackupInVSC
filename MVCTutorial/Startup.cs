using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.StaticFiles;
using MVCTutorial.Models;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MVCTutorial
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
            services.AddControllersWithViews();

            services.AddHttpContextAccessor();
            services.AddScoped<IIpReflection,IpReflectionModel>();
            services.AddDirectoryBrowser();
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();

            app.UseStaticFiles();


            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            //Add .apk file support
            var ExtProvider = new FileExtensionContentTypeProvider();
            ExtProvider.Mappings[".apk"] = "application/vnd.android.package-archive";
            
            string locationPath = env.ContentRootPath + @"/Storage";
            var fileLocation = new PhysicalFileProvider(locationPath);
            app.UseStaticFiles(new StaticFileOptions() { RequestPath =(PathString)"/ftp", FileProvider=fileLocation,ContentTypeProvider=ExtProvider});
            app.UseDirectoryBrowser(options:(new DirectoryBrowserOptions() { RequestPath="/ftp",FileProvider=fileLocation}));


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default", pattern: "{controller:alpha}/{action:alpha}/{id?}",
                    constraints:new {controller="[a-zA-Z0-9]*"},
                    defaults:new { controller="Home",action="Index"}
                    );
            });
        }
    }
}