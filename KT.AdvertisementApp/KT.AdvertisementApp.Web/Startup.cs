using AutoMapper;
using FluentValidation;
using KT.AdvertisementApp.Business.DependencyResolvers.Microsoft;
using KT.AdvertisementApp.Business.Helpers;
using KT.AdvertisementApp.Web.Mappings.AutoMapper;
using KT.AdvertisementApp.Web.Models;
using KT.AdvertisementApp.Web.ValidationRules;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDependencies(Configuration);
            services.AddTransient<IValidator<UserCreateModel>, UserCreateModelValidator>();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opt =>
    {
        opt.Cookie.Name = "AdvertisementCookie";
        opt.Cookie.HttpOnly = true;
        opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
        opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
        opt.ExpireTimeSpan = TimeSpan.FromDays(20);
        opt.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/SignIn");
        opt.LogoutPath = new Microsoft.AspNetCore.Http.PathString("/Account/LogOut");
        opt.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/AccessDenied");

    });

            services.AddControllersWithViews();

            var profiles = ProfileHelper.GetProfiles();
            profiles.Add(new UserCreateModelProfile());
            var configuration = new MapperConfiguration(opt =>
            {
                opt.AddProfiles(profiles);
                
            });
            var mapper = configuration.CreateMapper();
            services.AddSingleton(mapper);
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
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();
            app.UseAuthentication();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
