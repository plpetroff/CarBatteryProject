namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using CarBattery.Data.Common.Repositories;
    using CarBattery.Data.Models;

    public class TechnologyService : ITechnologyService
    {
        private readonly IDeletableEntityRepository<Technology> technologyRepository;

        public TechnologyService(IDeletableEntityRepository<Technology> technologyRepository)
        {
            this.technologyRepository = technologyRepository;
        }

        public IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuepairs()
        {
            return this.technologyRepository.All().Select(x => new
            {
                x.Id, x.Name,
            }).ToList().Select(x => new KeyValuePair<string, string>(x.Id.ToString(), x.Name)).OrderBy(x => x.Value);
        }
    }
}
