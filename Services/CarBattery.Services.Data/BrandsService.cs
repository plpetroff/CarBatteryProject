namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CarBattery.Data.Common.Repositories;
    using CarBattery.Data.Models;

    public class BrandsService : IBrandsService
    {
        private readonly IDeletableEntityRepository<Brand> brandsRepository;

        public BrandsService(IDeletableEntityRepository<Brand> brandsRepository)
        {
            this.brandsRepository = brandsRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuepairs()
        {
            return this.brandsRepository.AllAsNoTracking().Select(x => new
            {
                x.Id,
                x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name)).OrderBy(x => x.Key);
        }
    }
}
