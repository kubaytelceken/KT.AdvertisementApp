using AutoMapper;
using FluentValidation;
using KT.AdvertisementApp.Business.Interfaces;
using KT.AdvertisementApp.Business.Mappings.AutoMapper;
using KT.AdvertisementApp.Business.Services;
using KT.AdvertisementApp.Business.ValidationRules;
using KT.AdvertisementApp.DataAccess.Contexts;
using KT.AdvertisementApp.DataAccess.UnitOfWork;
using KT.AdvertisementApp.Dtos.AdvertisementDtos;
using KT.AdvertisementApp.Dtos.ProvidedServiceDtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.DependencyResolvers.Microsoft
{
    public static class DependencyExtension
    {
        public static void AddDependencies(this IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<AdvertisementContext>(opt =>
            {
                opt.UseSqlServer(configuration.GetConnectionString("Local"));
            });

            var mapperConfiguration = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new ProvidedServiceProfile());
                opt.AddProfile(new AdvertisementProfile());
            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);


            services.AddScoped<IUow, Uow>();

            services.AddTransient<IValidator<ProvidedServiceCreateDto>, ProvidedServiceCreateDtoValidator>();
            services.AddTransient<IValidator<ProvidedServiceUpdateDto>, ProvidedServiceUpdateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementCreateDto>, AdvertisementCreateDtoValidator>();
            services.AddTransient<IValidator<AdvertisementUpdateDto>, AdvertisementUpdateDtoValidator>();

            services.AddScoped<IProvidedServiceService, ProvidedServiceService>();
            services.AddScoped<IAdvertisementService, AdvertisementService>();
        }
    }
}
