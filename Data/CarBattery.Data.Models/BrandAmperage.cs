using System;
using System.Collections.Generic;
using System.Text;

namespace CarBattery.Data.Models
{
    public class BrandAmperage
    {
        public int Id { get; set; }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public int AmperageId { get; set; }

        public virtual Amperage Amperage { get; set; }

    }
}
