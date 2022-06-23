using KT.AdvertisementApp.Dtos.ProvidedServiceDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Interfaces
{
    public  interface IProvidedServiceService : IService<ProvidedServiceCreateDto,ProvidedServiceUpdateDto,ProvidedServiceListDto,ProvidedService>
    {

    }
}
