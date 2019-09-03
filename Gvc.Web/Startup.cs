using Gvc.Data.Contexts;
using Gvc.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gvc.Web
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
            var secrets = GetSecrets();
            if (secrets != null)
            {
                if (!string.IsNullOrEmpty(secrets.ConnectionStrings))
                {
                    services.AddDbContext<GvcDbContext>(options => options.UseSqlServer(secrets.ConnectionStrings));
                }
            }

            services.AddApplicationInsightsTelemetry();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // In production, the Angular files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "..\\Gvc.ClientApp/dist";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                // To learn more about options for serving an Angular SPA from ASP.NET Core,
                // see https://go.microsoft.com/fwlink/?linkid=864501

                spa.Options.SourcePath = "..\\Gvc.ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseAngularCliServer(npmScript: "start");
                }
            });
        }

        private Secrets GetSecrets()
        {
            return new Secrets()
            {
                ConnectionStrings = Configuration.GetConnectionString("gvc"),
                //ConnectionStrings = Configuration.GetConnectionString("gvcMySql"),
                //FaceBookAppId = Configuration.GetValue<string>("FaceBookAppId"),
                //FaceBookAppSecret = Configuration.GetValue<string>("FaceBookAppSecret"),
                //SymmetricSecurityKey = Configuration.GetValue<string>("SymmetricSecurityKey")
            };
        }
    }
}
