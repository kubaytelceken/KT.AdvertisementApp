using AutoMapper;
using FluentValidation;
using KT.AdvertisementApp.Business.Interfaces;
using KT.AdvertisementApp.DataAccess.UnitOfWork;
using KT.AdvertisementApp.Dtos.GenderDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Services
{
    public class GenderService : Service<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender>,IGenderService
    {
        public GenderService(IMapper mapper, IValidator<GenderCreateDto> createDtoValidator, IValidator<GenderUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {

        }
    }
}
