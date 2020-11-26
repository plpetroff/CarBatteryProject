namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CarBattery.Web.ViewModels.Home;

    public interface IGetCountsService
    {
        // 1 use ViewModel
        IndexViewModel GetCounts();
    }
}
