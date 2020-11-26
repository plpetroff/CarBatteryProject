using CarBattery.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBattery.Data.Models
{
    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Batteries = new HashSet<Battery>();
        }
        public string Name { get; set; }

        public virtual ICollection<Battery> Batteries { get; set; }

    }
}
