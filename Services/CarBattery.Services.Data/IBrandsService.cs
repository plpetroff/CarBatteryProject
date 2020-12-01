namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IBrandsService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuepairs();
    }
}
