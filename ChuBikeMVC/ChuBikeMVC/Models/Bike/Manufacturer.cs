using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChuBikeMVC.Models.Bike
{
    public class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Addres { get; set; }

        public ICollection<Part> Parts { get; set; }
    }
}