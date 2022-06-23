﻿using KT.AdvertisementApp.Business.Interfaces;
using KT.AdvertisementApp.Web.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KT.AdvertisementApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProvidedServiceService _providedServiceService;
        private readonly IAdvertisementService _advertisementService;

        public HomeController(IProvidedServiceService providedServiceService, IAdvertisementService advertisementService)
        {
            _providedServiceService = providedServiceService;
            _advertisementService = advertisementService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _providedServiceService.GetAllAsync();
            return this.ResponseView(response);
           
        }

        public async Task<IActionResult> HumanResource()
        {
            var response = await _advertisementService.GetActiveAsync();
            return this.ResponseView(response);
        }
    }
}