namespace CarBattery.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CarBattery.Data.Models;

    public class TechnologySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Technologies.Any())
            {
                return;
            }

            await dbContext.Technologies.AddAsync(new Technology { Name = "Calcium" });
            await dbContext.Technologies.AddAsync(new Technology { Name = "AGM" });
            await dbContext.Technologies.AddAsync(new Technology { Name = "EFB" });
            await dbContext.Technologies.AddAsync(new Technology { Name = "Gel" });

            await dbContext.SaveChangesAsync();
        }
    }
}
