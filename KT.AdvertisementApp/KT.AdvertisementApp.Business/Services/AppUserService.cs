using AutoMapper;
using FluentValidation;
using KT.AdvertisementApp.Business.Extensions;
using KT.AdvertisementApp.Business.Interfaces;
using KT.AdvertisementApp.Common;
using KT.AdvertisementApp.DataAccess.UnitOfWork;
using KT.AdvertisementApp.Dtos.AppRoleDtos;
using KT.AdvertisementApp.Dtos.AppUserDtos;
using KT.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Business.Services
{
    public class AppUserService : Service<AppUserCreateDto,AppUserUpdateDto,AppUserListDto,AppUser> , IAppUserService
    {
        private readonly IValidator<AppUserCreateDto> _appUserCreateDtoValidator;
        private readonly IValidator<AppUserLoginDto> _appUserLoginDtoValidator;
        private readonly IMapper _mapper;
        private readonly IUow _uow;
        public AppUserService(IMapper mapper, IValidator<AppUserCreateDto> appUserCreateDtoValidator, IValidator<AppUserUpdateDto> appUserUpdateDtoValidator, IUow uow, IValidator<AppUserLoginDto> appUserLoginDtoValidator) : base(mapper, appUserCreateDtoValidator, appUserUpdateDtoValidator, uow)
        {
            _uow = uow;
            _mapper = mapper;
            _appUserCreateDtoValidator = appUserCreateDtoValidator;
            _appUserLoginDtoValidator = appUserLoginDtoValidator;
        }

        public async Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto,int roleId)
        {
            var validationResult = _appUserCreateDtoValidator.Validate(dto);
            if (validationResult.IsValid)
            {
                var data = _mapper.Map<AppUser>(dto);
                //data.AppUserRoles = new List<AppUserRole>();
                //data.AppUserRoles.Add(new AppUserRole
                //{
                //    AppUser = data,
                //    AppRoleId = roleId
                //});
                await _uow.GetRepository<AppUser>().CreateAsync(data);

                // 2.adım
                await _uow.GetRepository<AppUserRole>().CreateAsync(new AppUserRole
                {
                    AppRoleId = roleId,
                    AppUser = data
                });
                await _uow.SaveChangesAsync();
                return new Response<AppUserCreateDto>(ResponseType.Success, dto);
            }
            return new Response<AppUserCreateDto>(dto, validationResult.ConvertToCustomValidationError());
        }


        public async Task<IResponse<AppUserListDto>> CheckUser(AppUserLoginDto appUserLoginDto)
        {
            var validationResult = _appUserLoginDtoValidator.Validate(appUserLoginDto);
            if (validationResult.IsValid)
            {
                var user = await _uow.GetRepository<AppUser>().GetByFilterAsync(x => x.Username == appUserLoginDto.Username && x.Password == appUserLoginDto.Password);
                if(user != null)
                {
                    var appUserDto = _mapper.Map<AppUserListDto>(user);
                    return new Response<AppUserListDto>(ResponseType.Success, appUserDto);
                }
                return new Response<AppUserListDto>(ResponseType.NotFound, "Kullanıcı adı veya şifre hatalı");
            }
            return new Response<AppUserListDto>(ResponseType.ValidationError, "Kullanıcı Adı veya şifre boş olamaz");
        }

        public async Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId)
        {
            var roles = await _uow.GetRepository<AppRole>().GetAllAsync(x => x.AppUserRoles.Any(x => x.AppUserId == userId));
            if (roles == null)
            {
                return new Response<List<AppRoleListDto>>(ResponseType.NotFound, "İlgili Rol Bulunamadı");
            }
            var dto = _mapper.Map<List<AppRoleListDto>>(roles);
            return new Response<List<AppRoleListDto>>(ResponseType.Success, dto);
        }
    }
}
