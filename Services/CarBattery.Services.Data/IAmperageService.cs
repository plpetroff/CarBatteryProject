namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IAmperageService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuepairs();
    }
}
