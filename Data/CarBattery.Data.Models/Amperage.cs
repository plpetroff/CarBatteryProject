namespace CarBattery.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using CarBattery.Data.Common.Models;

    public class Amperage : BaseDeletableModel<int>
    {
        public Amperage()
        {
            this.Brands = new HashSet<BrandAmperage>();
            this.Batteries = new HashSet<Battery>();
        }

        public int Value { get; set; }

        [Required]
        [MaxLength(5)]
        public string Abbr { get; set; }

        public virtual ICollection<Battery> Batteries { get; set; }

        public virtual ICollection<BrandAmperage> Brands { get; set; }
    }
}
