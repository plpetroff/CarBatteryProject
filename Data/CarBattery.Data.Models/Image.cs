using CarBattery.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarBattery.Data.Models
{
    public class Image : BaseModel<string>
    {
        public Image()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int BatteryId { get; set; }

        public virtual Battery Battery { get; set; }


        public string Extension { get; set; }
        // the content of the image is in the file system
    }
}
