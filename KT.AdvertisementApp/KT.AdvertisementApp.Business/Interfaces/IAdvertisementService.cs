using KT.AdvertisementApp.Common;
using KT.AdvertisementApp.Dtos.AdvertisementDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Interfaces
{
    public interface IAdvertisementService : IService<AdvertisementCreateDto,AdvertisementUpdateDto,AdvertisementListDto,Advertisement>
    {
        Task<IResponse<List<AdvertisementListDto>>> GetActiveAsync();
    }
}
