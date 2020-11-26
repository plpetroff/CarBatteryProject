namespace CarBattery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using CarBattery.Data.Common.Models;

    public class Battery : BaseDeletableModel<int>
    {
        public Battery()
        {
            this.Images = new HashSet<Image>();
        }

        public int BrandId { get; set; }

        public virtual Brand Brand { get; set; }

        public int AmperageId { get; set; }

        public virtual Amperage Amperage { get; set; }

        public int CapacityId { get; set; }

        public virtual Capacity Capacity { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int TechnologyId { get; set; }

        public virtual Technology Technology { get; set; }

        public string BatteryDescription { get; set; }

        public virtual ICollection<Image> Images { get; set; }



    }
}
