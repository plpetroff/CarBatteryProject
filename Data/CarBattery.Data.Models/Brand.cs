namespace CarBattery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using CarBattery.Data.Common.Models;

    public class Brand : BaseDeletableModel<int>
    {
        public Brand()
        {
            this.Amperages = new HashSet<BrandAmperage>();
            this.Capacities = new HashSet<BrandCapacity>();
            this.Batteries = new HashSet<Battery>();
        }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        public virtual ICollection<Battery> Batteries { get; set; }
        public virtual ICollection<BrandAmperage> Amperages { get; set; }

        public virtual ICollection<BrandCapacity> Capacities { get; set; }
    }
}
