using AutoMapper;
using KT.AdvertisementApp.Dtos.AdvertisementDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class AdvertisementProfile : Profile
    {
        public AdvertisementProfile()
        {
            CreateMap<Advertisement, AdvertisementListDto>().ReverseMap();
            CreateMap<Advertisement, AdvertisementCreateDto>().ReverseMap();
            CreateMap<Advertisement, AdvertisementUpdateDto>().ReverseMap();
        }
    }
}
