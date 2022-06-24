using AutoMapper;
using KT.AdvertisementApp.Dtos.GenderDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class GenderProfile : Profile
    {
        public GenderProfile()
        {
            CreateMap<Gender, GenderListDto>().ReverseMap();
            CreateMap<Gender, GenderUpdateDto>().ReverseMap();
            CreateMap<Gender, GenderCreateDto>().ReverseMap();
        }
    }
}
