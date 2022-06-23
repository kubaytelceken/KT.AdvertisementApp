using AutoMapper;
using FluentValidation;
using KT.AdvertisementApp.Business.Interfaces;
using KT.AdvertisementApp.Common;
using KT.AdvertisementApp.DataAccess.UnitOfWork;
using KT.AdvertisementApp.Dtos.AdvertisementDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Services
{
    public class AdvertisementService : Service<AdvertisementCreateDto, AdvertisementUpdateDto, AdvertisementListDto, Advertisement>, IAdvertisementService
    {
        private readonly IUow _uow;
        private readonly IMapper _mapper;
        public AdvertisementService(IMapper mapper, IValidator<AdvertisementCreateDto> createDtoValidator, IValidator<AdvertisementUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
            _mapper = mapper;
               _uow = uow;
        }

        public async Task<IResponse<List<AdvertisementListDto>>> GetActiveAsync()
        {
            var data = await _uow.GetRepository<Advertisement>().GetAllAsync(x => x.Status, x => x.CreatedDate, Common.Enums.OrderByType.DESC);
            var dto =  _mapper.Map<List<AdvertisementListDto>>(data);

            return new Response<List<AdvertisementListDto>>(ResponseType.Success, dto);
        }
    }
}
