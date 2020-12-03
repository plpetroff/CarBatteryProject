﻿namespace CarBattery.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface ICapacityService
    {
        IEnumerable<KeyValuePair<string, string>> GetAllAsKeyValuepairs();
    }
}
