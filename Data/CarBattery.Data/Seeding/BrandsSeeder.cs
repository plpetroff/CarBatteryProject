namespace CarBattery.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CarBattery.Data.Models;

    public class BrandsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Brands.Any())
            {
                return;
            }

            await dbContext.Brands.AddAsync(new Brand { Name = "Cronus" });
            await dbContext.Brands.AddAsync(new Brand { Name = "Varta" });
            await dbContext.Brands.AddAsync(new Brand { Name = "Bosch" });
            await dbContext.Brands.AddAsync(new Brand { Name = "Banner" });
            await dbContext.Brands.AddAsync(new Brand { Name = "Monbat" });
            await dbContext.Brands.AddAsync(new Brand { Name = "Free Max" });
            await dbContext.Brands.AddAsync(new Brand { Name = "JP MOTO" });

            await dbContext.SaveChangesAsync();
        }
    }
}
