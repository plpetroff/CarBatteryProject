namespace CarBattery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CarBattery.Data.Common.Models;

    public class Capacity : BaseDeletableModel<int>
    {
        public Capacity()
        {
            this.Brands = new HashSet<BrandCapacity>();
            this.Batteries = new HashSet<Battery>();

        }

        public int BatteryAh { get; set; }

        public virtual ICollection<Battery> Batteries { get; set; }

        public virtual ICollection<BrandCapacity> Brands { get; set; }
    }
}
