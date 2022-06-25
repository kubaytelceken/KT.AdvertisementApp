using AutoMapper;
using FluentValidation;
using KT.AdvertisementApp.Business.Interfaces;
using KT.AdvertisementApp.Common.Enums;
using KT.AdvertisementApp.Dtos.AdvertisementDtos;
using KT.AdvertisementApp.Dtos.AppUserDtos;
using KT.AdvertisementApp.Web.Extensions;
using KT.AdvertisementApp.Web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IGenderService _genderService;
        private readonly IValidator<UserCreateModel> _userCreateModelValidator;
        private readonly IAppUserService _appUserService;
        private readonly IMapper _mapper;

        public AccountController(IGenderService genderService, IValidator<UserCreateModel> userCreateModelValidator, IAppUserService appUserService, IMapper mapper)
        {
            _genderService = genderService;
            _userCreateModelValidator = userCreateModelValidator;
            _appUserService = appUserService;
            _mapper = mapper;
        }

        public async Task<IActionResult> SignUp()
        {
            
               var response = await _genderService.GetAllAsync();
            var model = new UserCreateModel();
            model.Genders = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(response.Data,"Id","Definition");
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(UserCreateModel userCreateModel)
        {
            var result = _userCreateModelValidator.Validate(userCreateModel);
            if (result.IsValid)
            {
                var dto = _mapper.Map<AppUserCreateDto>(userCreateModel);
                var createResponse = await _appUserService.CreateWithRoleAsync(dto, (int)RoleType.Member);
                return this.ResponseRedirectAction(createResponse, "SignIn");
      
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.PropertyName, error.ErrorMessage);
            }
            var response = await _genderService.GetAllAsync();
            userCreateModel.Genders = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(response.Data, "Id", "Definition",userCreateModel.GenderId);
            return View(userCreateModel);
        }

        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(AppUserLoginDto dto)
        {
            if (ModelState.IsValid)
            {
                var result = await _appUserService.CheckUser(dto);
                if(result.ResponseType == Common.ResponseType.Success)
                {
                    var roleResult = await _appUserService.GetRolesByUserIdAsync(result.Data.Id);
                    var claims = new List<Claim>();
                    if(roleResult.ResponseType == Common.ResponseType.Success)
                    {
                        foreach (var item in roleResult.Data)
                        {
                            claims.Add(new Claim(ClaimTypes.Role, item.Definition));
                        }
                        claims.Add(new Claim(ClaimTypes.NameIdentifier, result.Data.Id.ToString()));
                        claims.Add(new Claim(ClaimTypes.Name, result.Data.Username));
                    }

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {
                        IsPersistent = dto.RememberMe,

                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("Kullanıcı adı veya şifre hatalı", result.Message);
                }
            }
            return View(dto);
        }


        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Home");
        }


  
    }
}
