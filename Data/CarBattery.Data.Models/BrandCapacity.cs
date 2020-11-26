using System;
using System.Collections.Generic;
using System.Text;

namespace CarBattery.Data.Models
{
    public class BrandCapacity
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public int CapacityId { get; set; }

        public virtual Capacity Capacity { get; set; }

    }
}
