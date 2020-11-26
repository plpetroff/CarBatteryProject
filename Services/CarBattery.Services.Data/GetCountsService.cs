namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CarBattery.Data.Common.Repositories;
    using CarBattery.Data.Models;
    using CarBattery.Web.ViewModels.Home;

    public class GetCountsService : IGetCountsService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;
        private readonly IRepository<Image> imagesRepository;
        private readonly IDeletableEntityRepository<Battery> batteryRepository;
        private readonly IDeletableEntityRepository<Brand> brandRepository;

        public GetCountsService(
            IDeletableEntityRepository<Category> categoriesRepository,
            IRepository<Image> imagesRepository,
            IDeletableEntityRepository<Battery> batteryRepository,
            IDeletableEntityRepository<Brand> brandRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.imagesRepository = imagesRepository;
            this.batteryRepository = batteryRepository;
            this.brandRepository = brandRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                BatteryCount = this.batteryRepository.All().Count(),
                CategoriesCount = this.categoriesRepository.All().Count(),
                BrandsCount = this.brandRepository.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
            };

            return data;
        }
    }
}
