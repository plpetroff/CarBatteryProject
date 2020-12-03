namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using CarBattery.Web.ViewModels.Battery;

    public interface IBatteryService
    {
        Task CreateAsync(CreateBatteryInputModel input);
    }
}
