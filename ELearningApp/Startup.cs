using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ELearningApp.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ELearningApp.API.Settings;
using Microsoft.Extensions.Options;
using ELearningApp.API.Services;
using ELearningApp.HttpClients;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace ELearningApp
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<IdentityUser>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // requires using Microsoft.Extensions.Options
            services.Configure<E_LearningDatabaseSettings>(
                Configuration.GetSection(nameof(E_LearningDatabaseSettings)));

            services.AddSingleton<IE_LearningDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<E_LearningDatabaseSettings>>().Value);

            services.AddSingleton<UserService>(); //adding Singleton UserService
            services.AddSingleton<CourseService>(); //adding Singleton CourseService
            services.AddSingleton<SchoolService>(); //adding Singleton SchoolService
            services.AddSingleton<CategoryService>(); //adding Singleton CategoryService

            services.AddHttpClient<CourseHttp>();

            services.AddAuthentication(options =>
            {
                options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
          .AddCookie(
              options =>
              {
                  
                  options.LoginPath = "/Account/Login/";
                  options.LogoutPath = "/Account/Logout/";
                  options.AccessDeniedPath = "/Account/NoAccess/";
                  options.ExpireTimeSpan = TimeSpan.FromDays(7);
                  options.SlidingExpiration = true;
              }
              );
            var cookiePolicyOptions = new CookiePolicyOptions
            {
                MinimumSameSitePolicy = SameSiteMode.Strict,
            };
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseStatusCodePages();
            app.UseAuthentication();
          
            app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
