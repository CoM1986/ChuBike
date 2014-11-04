using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChuBikeMVC.Models.Bike
{
    public class PartType
    {
        public PartType()
        {
           List<Part> PartsList = new List<Part>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}