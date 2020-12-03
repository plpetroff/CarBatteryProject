namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using CarBattery.Data.Common.Repositories;
    using CarBattery.Data.Models;
    using CarBattery.Web.ViewModels.Battery;

    public class BatteryService : IBatteryService
    {
        private readonly IDeletableEntityRepository<Battery> batteryRepository;

        public BatteryService(IDeletableEntityRepository<Battery> batteryRepository)
        {
            this.batteryRepository = batteryRepository;
        }

        public async Task CreateAsync(CreateBatteryInputModel input)
        {
            var battery = new Battery();
            battery.BrandId = input.BrandId;
            battery.AmperageId = input.AmperageId;
            battery.CapacityId = input.CapacityId;
            battery.CategoryId = input.CategoryId;
            battery.TechnologyId = input.TechnologyId;
            battery.BatteryDescription = input.BatteryDescription;

            await this.batteryRepository.AddAsync(battery);
            await this.batteryRepository.SaveChangesAsync();

        }

        

    }
}
