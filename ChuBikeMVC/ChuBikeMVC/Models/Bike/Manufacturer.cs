using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChuBikeMVC.Models.Bike
{
    public class Manufacturer
    {
        public Manufacturer()
        {
            List<Part> PartsList = new List<Part>();
        }
        public int ManufacturerId { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}