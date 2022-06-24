using AutoMapper;
using KT.AdvertisementApp.Dtos.AppUserDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUser, AppUserListDto>().ReverseMap();
            CreateMap<AppUser, AppUserCreateDto>().ReverseMap();
            CreateMap<AppUser, AppUserUpdateDto>().ReverseMap();
        }
    }
}
