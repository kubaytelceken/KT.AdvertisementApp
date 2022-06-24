using KT.AdvertisementApp.Dtos.GenderDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Interfaces
{
    public interface IGenderService : IService<GenderCreateDto,GenderUpdateDto,GenderListDto,Gender>
    {

    }
}
