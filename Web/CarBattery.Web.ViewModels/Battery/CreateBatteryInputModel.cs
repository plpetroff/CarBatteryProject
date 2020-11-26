using CarBattery.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CarBattery.Web.ViewModels.Battery
{
    public class CreateBatteryInputModel
    {
        [Required]
        [MinLength(3)]
        [Display(Name = "This displayed brand")]
        public virtual Brand Brand { get; set; }

        [Required]
        [Display(Name = "This display Amperage")]
        public virtual Amperage Amperage { get; set; }

        [Required]
        [Display(Name = "This display Capacity")]
        public virtual Capacity Capacity { get; set; }

        [Required]
        public virtual Category Category { get; set; }

        [Required]
        [MinLength(2)]
        public virtual Technology Technology { get; set; }

        public string BatteryDescription { get; set; }


        public virtual ICollection<Image> Images { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
    }
}
