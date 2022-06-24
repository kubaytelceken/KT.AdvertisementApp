using AutoMapper;
using KT.AdvertisementApp.Dtos.AppUserDtos;
using KT.AdvertisementApp.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Web.Mappings.AutoMapper
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>().ReverseMap();
        }
    }
}
