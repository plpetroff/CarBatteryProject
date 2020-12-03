namespace CarBattery.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CarBattery.Data.Models;

    public class AmperagesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Amperages.Any())
            {
                return;
            }

            await dbContext.Amperages.AddAsync(new Amperage { Value = 100, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 150, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 200, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 250, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 300, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 350, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 400, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 450, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 500, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 550, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 600, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 650, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 700, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 750, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 800, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 850, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 900, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 950, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 1000, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 1100, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 1200, Abbr = "EN" });
            await dbContext.Amperages.AddAsync(new Amperage { Value = 1300, Abbr = "EN" });

            await dbContext.SaveChangesAsync();
        }
    }
}
