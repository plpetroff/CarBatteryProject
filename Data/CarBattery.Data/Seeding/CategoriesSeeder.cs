namespace CarBattery.Data.Seeding
{
    using CarBattery.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            await dbContext.Categories.AddAsync(new Category {Name = "Стартерни" });
            await dbContext.Categories.AddAsync(new Category {Name = "Мото" });
            await dbContext.Categories.AddAsync(new Category {Name = "Камиони" });
            await dbContext.Categories.AddAsync(new Category {Name = "Тягови" });

            await dbContext.SaveChangesAsync();
        }
    }
}
