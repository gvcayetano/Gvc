using Gvc.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using GvcDbContext = Gvc.Web.Contexts.GvcDbContext;

namespace Gvc.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        private IHostingEnvironment HostingEnvironment { get;  }

        public Startup(IConfiguration configuration, IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            HostingEnvironment = hostingEnvironment;
        }

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

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "Gvc.ClientApp/build";
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
                spa.Options.SourcePath = "..\\Gvc.ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }

        private Secrets GetSecrets()
        {
            return new Secrets()
            {
                ConnectionStrings = HostingEnvironment.IsDevelopment() ? Configuration.GetConnectionString("gvc-dev") : Configuration.GetConnectionString("gvc"),
                //ConnectionStrings = Configuration.GetConnectionString("gvcMySql"),
                //FaceBookAppId = Configuration.GetValue<string>("FaceBookAppId"),
                //FaceBookAppSecret = Configuration.GetValue<string>("FaceBookAppSecret"),
                //SymmetricSecurityKey = Configuration.GetValue<string>("SymmetricSecurityKey")
            };
        }
    }
}
