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
        private readonly IDeletableEntityRepository<Technology> technologyRepository;

        public GetCountsService(
            IDeletableEntityRepository<Category> categoriesRepository,
            IRepository<Image> imagesRepository,
            IDeletableEntityRepository<Battery> batteryRepository,
            IDeletableEntityRepository<Brand> brandRepository,
            IDeletableEntityRepository<Technology> technologyRepository)
        {
            this.categoriesRepository = categoriesRepository;
            this.imagesRepository = imagesRepository;
            this.batteryRepository = batteryRepository;
            this.brandRepository = brandRepository;
            this.technologyRepository = technologyRepository;
        }

        public IndexViewModel GetCounts()
        {
            var data = new IndexViewModel
            {
                BatteryCount = this.batteryRepository.All().Count(),
                CategoriesCount = this.categoriesRepository.All().Count(),
                BrandsCount = this.brandRepository.All().Count(),
                ImagesCount = this.imagesRepository.All().Count(),
                TechnologyCount = this.technologyRepository.All().Count(),
            };

            return data;
        }
    }
}
