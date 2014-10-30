using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChuBikeMVC.Models.Bike;

namespace ChuBikeMVC.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        public int TypeId { get; set; }
        public virtual PartType PartsType { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}