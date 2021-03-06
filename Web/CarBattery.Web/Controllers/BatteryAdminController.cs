﻿namespace CarBattery.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using CarBattery.Services.Data;
    using CarBattery.Web.ViewModels.Battery;
    using Microsoft.AspNetCore.Mvc;

    public class BatteryAdminController : Controller
    {
        private readonly ICategoriesService categoriesService;
        private readonly IBrandsService brandsService;
        private readonly IBatteryService batteryService;
        private readonly ICapacityService capacityService;
        private readonly IAmperageService amperageService;
        private readonly ITechnologyService technologyService;

        public BatteryAdminController(
            ICategoriesService categoriesService,
            IBrandsService brandsService,
            IBatteryService batteryService,
            ICapacityService capacityService,
            IAmperageService amperageService,
            ITechnologyService technologyService)
        {
            this.categoriesService = categoriesService;
            this.brandsService = brandsService;
            this.batteryService = batteryService;
            this.capacityService = capacityService;
            this.amperageService = amperageService;
            this.technologyService = technologyService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateBatteryInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
            viewModel.BrandsItems = this.brandsService.GetAllAsKeyValuepairs();
            viewModel.CapacityItems = this.capacityService.GetAllAsKeyValuepairs();
            viewModel.AmperageItems = this.amperageService.GetAllAsKeyValuepairs();
            viewModel.TechnologyItems = this.technologyService.GetAllAsKeyValuepairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBatteryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuePairs();
                input.BrandsItems = this.brandsService.GetAllAsKeyValuepairs();
                input.CapacityItems = this.capacityService.GetAllAsKeyValuepairs();
                input.AmperageItems = this.amperageService.GetAllAsKeyValuepairs();
                input.TechnologyItems = this.technologyService.GetAllAsKeyValuepairs();
                return this.View(input);
            }

            // return this.Json(input);
            await this.batteryService.CreateAsync(input);

            // TODO create Battery using service method
            // TODO redirect to Battery info-page
            return this.Redirect("/");
        }
    }
}
