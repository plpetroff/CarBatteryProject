namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CarBattery.Data.Common.Repositories;
    using CarBattery.Data.Models;

    public class CapacityService : ICapacityService
    {
        private readonly IDeletableEntityRepository<Capacity> capacitiesRepository;

        public CapacityService(IDeletableEntityRepository<Capacity> capacitiesRepository)
        {
            this.capacitiesRepository = capacitiesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuepairs()
        {
            return this.capacitiesRepository.AllAsNoTracking().Select(x => new
            {
                x.Id,
                x.BatteryAh,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.BatteryAh.ToString()));
        }
    }
}
