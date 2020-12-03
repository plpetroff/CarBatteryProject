namespace CarBattery.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using CarBattery.Data.Models;

    public class CapacitySeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Capacities.Any())
            {
                return;
            }

            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 44 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 48 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 50 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 55 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 58 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 60 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 63 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 66 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 70 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 72 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 75 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 77 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 80 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 85 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 90 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 95 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 100 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 110 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 120 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 130 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 140 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 150 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 160 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 170 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 180 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 190 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 210 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 220 });
            await dbContext.Capacities.AddAsync(new Capacity { BatteryAh = 230 });

            await dbContext.SaveChangesAsync();
        }
    }
}
