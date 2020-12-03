namespace CarBattery.Web.ViewModels.Battery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using CarBattery.Data.Models;

    public class CreateBatteryInputModel
    {
        [Required]
        [Display(Name = "This displayed brand")]
        public int BrandId { get; set; }

        [Required]
        [Display(Name = "This display Capacity")]
        public int CapacityId { get; set; }

        [Required]
        [Display(Name = "This display Amperage")]
        public int AmperageId { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [Required]
        public int TechnologyId { get; set; }

        public string BatteryDescription { get; set; }

        public virtual ICollection<Image> Images { get; set; }

        public IEnumerable<KeyValuePair<string, string>> CategoriesItems { get; set; }
        public IEnumerable<KeyValuePair<string, string>> BrandsItems { get; set; }
        public IEnumerable<KeyValuePair<string, string>> CapacityItems { get; set; }
    }
}
