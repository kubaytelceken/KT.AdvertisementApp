using KT.AdvertisementApp.Common;
using KT.AdvertisementApp.Dtos.AppRoleDtos;
using KT.AdvertisementApp.Dtos.AppUserDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Interfaces
{
    public interface IAppUserService : IService<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser>
    {
        Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId);
        Task<IResponse<AppUserListDto>> CheckUser(AppUserLoginDto appUserLoginDto);
        Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId);
    }
}
