using CarBattery.Services.Data;
using CarBattery.Web.ViewModels.Battery;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarBattery.Web.Controllers
{
    public class BatteryAdminController : Controller
    {
        private readonly ICategoriesService categoriesService;

        public BatteryAdminController(ICategoriesService categoriesService)
        {
            this.categoriesService = categoriesService;
        }
        public IActionResult Create()
        {
            var viewModel = new CreateBatteryInputModel();
            viewModel.CategoriesItems = this.categoriesService.GetAllAsKeyValuepairs();
            return this.View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CreateBatteryInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                input.CategoriesItems = this.categoriesService.GetAllAsKeyValuepairs();
                return this.View(input);
            }

            //TODO create Battery using service method
            //TODO redirect to Battery info-page
            return this.Redirect("/");
        }
    }
}
