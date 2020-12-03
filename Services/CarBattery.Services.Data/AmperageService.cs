namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CarBattery.Data.Common.Repositories;
    using CarBattery.Data.Models;

    public class AmperageService : IAmperageService
    {
        private readonly IDeletableEntityRepository<Amperage> amperagesRepository;

        public AmperageService(IDeletableEntityRepository<Amperage> amperagesRepository)
        {
            this.amperagesRepository = amperagesRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuepairs()
        {
            return this.amperagesRepository.All().Select(x => new
            {
                x.Id,
                x.Value,
            }).ToList().OrderBy(x => x.Value).Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Value.ToString()));
        }
    }
}
