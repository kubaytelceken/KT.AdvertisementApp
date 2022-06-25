﻿using KT.AdvertisementApp.Common;
using KT.AdvertisementApp.Dtos.Interfaces;
using KT.AdvertisementApp.Dtos.ProvidedServiceDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Interfaces
{
    public interface IService<CreateDto,UpdateDto,ListDto,T>
        where CreateDto :class , IDto , new ()
        where UpdateDto : class , IUpdateDto , new ()
        where ListDto : class , IDto , new ()
        where T : BaseEntity
    {
        Task<IResponse<CreateDto>> CreateAsync(CreateDto providedServiceCreateDto);
        Task<IResponse<UpdateDto>> UpdateAsync(UpdateDto providedServiceUpdateDto);
        Task<IResponse<IDto>> GetByIdAsync<IDto>(int id);
        Task<IResponse> RemoveAsync(int id);
        Task<IResponse<List<ListDto>>> GetAllAsync();

    }
}
