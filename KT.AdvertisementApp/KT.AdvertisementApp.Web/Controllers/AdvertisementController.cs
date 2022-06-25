using KT.AdvertisementApp.Business.Interfaces;
using KT.AdvertisementApp.Common.Enums;
using KT.AdvertisementApp.Dtos.AdvertisementAppUserDtos;
using KT.AdvertisementApp.Dtos.AppUserDtos;
using KT.AdvertisementApp.Dtos.MilitaryStatusDto;
using KT.AdvertisementApp.Web.Extensions;
using KT.AdvertisementApp.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Web.Controllers
{
    public class AdvertisementController : Controller
    {
        private readonly IAppUserService _appUserService;
        private readonly IAdvertisementAppUserService _advertisementAppUserService;

        public AdvertisementController(IAppUserService appUserService, IAdvertisementAppUserService advertisementAppUserService)
        {
            _appUserService = appUserService;
            _advertisementAppUserService = advertisementAppUserService;
        }


        [Authorize(Roles ="Member")]
        public async Task<IActionResult> Send(int advertisementId)
        {
            var userId =int.Parse((User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)).Value);
            var userInfo = await _appUserService.GetByIdAsync<AppUserListDto>(userId);
            ViewBag.GenderId = userInfo.Data.GenderId;
            var items = Enum.GetValues(typeof(MilitaryStatusType));

            var list = new List<MilitaryStatusListDto>();

            foreach (int item in items)
            {
                list.Add(new MilitaryStatusListDto
                {
                    Id = item,
                    Definition = Enum.GetName(typeof(MilitaryStatusType), item)
                });
            }
            ViewBag.MilitaryStatus = new SelectList(list, "Id", "Definition");

            return View(new AdvertisementAppUserCreateModel{ 
                AdvertisementId = advertisementId,
                AppUserId = userId
            });
        }
        
        [HttpPost]
        [Authorize(Roles ="Member")]
        public async Task<IActionResult> Send(AdvertisementAppUserCreateModel model)
        {
            AdvertisementAppUserCreateDto advertisementAppUserCreateDto = new AdvertisementAppUserCreateDto();
            if(model.CvFile != null)
            {
                var filename = Guid.NewGuid().ToString();
                var extname = Path.GetExtension(model.CvFile.FileName);
                string path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","cvFiles",filename + extname);
                var stream = new FileStream(path, FileMode.Create);
                await model.CvFile.CopyToAsync(stream);
                advertisementAppUserCreateDto.CvPath = path;
            }
            advertisementAppUserCreateDto.AdvertisementAppUserStatusId = model.AdvertisementAppUserStatusId;
            advertisementAppUserCreateDto.AdvertisementId = model.AdvertisementId;
            advertisementAppUserCreateDto.AppUserId = model.AppUserId;
            advertisementAppUserCreateDto.EndDate = model.EndDate;
            advertisementAppUserCreateDto.MilitaryStatusId = model.MilitaryStatusId;
            advertisementAppUserCreateDto.WorkExperience = model.WorkExperience;



            var response = await _advertisementAppUserService.CreateAsync(advertisementAppUserCreateDto);
            if(response.ResponseType  == Common.ResponseType.ValidationError)
            {

                foreach (var item in response.ValidationErrors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                var userId = int.Parse((User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)).Value);
                var userInfo = await _appUserService.GetByIdAsync<AppUserListDto>(userId);
                ViewBag.GenderId = userInfo.Data.GenderId;
                var items = Enum.GetValues(typeof(MilitaryStatusType));

                var list = new List<MilitaryStatusListDto>();

                foreach (int item in items)
                {
                    list.Add(new MilitaryStatusListDto
                    {
                        Id = item,
                        Definition = Enum.GetName(typeof(MilitaryStatusType), item)
                    });
                }
                ViewBag.MilitaryStatus = new SelectList(list, "Id", "Definition");
                return View(model);
            }
            else
            {
                return RedirectToAction("HumanResource", "Home");
            }
        }

        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> List()
        {
            var list = await _advertisementAppUserService.GetList(AdvertisementAppUserStatusType.Basvuru);

            return View(list);
        }


        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> SetStatus(int advertisementAppUserId,AdvertisementAppUserStatusType type)
        {
            await _advertisementAppUserService.SetStatusAsync(advertisementAppUserId, type);
            return RedirectToAction("List");
        }


        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ApprovedList()
        {
            var list = await _advertisementAppUserService.GetList(AdvertisementAppUserStatusType.Mulakat);

            return View(list);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RejectedList()
        {
            var list = await _advertisementAppUserService.GetList(AdvertisementAppUserStatusType.Olumsuz);

            return View(list);
        }
    }
}
