namespace CarBattery.Web.Controllers
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

        public BatteryAdminController(
            ICategoriesService categoriesService,
            IBrandsService brandsService)
        {
            this.categoriesService = categoriesService;
            this.brandsService = brandsService;
        }

        public IActionResult Create()
        {
            var viewModel = new CreateBatteryInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuepairs();
            viewModel.BrandsItems = this.brandsService.GetAllAsKeyValuepairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateBatteryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuepairs();
                input.BrandsItems = this.brandsService.GetAllAsKeyValuepairs();
                return this.View(input);
            }

            // TODO create Battery using service method
            // TODO redirect to Battery info-page
            return this.Redirect("/");
        }
    }
}
