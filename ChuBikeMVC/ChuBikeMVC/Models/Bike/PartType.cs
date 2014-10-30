using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChuBikeMVC.Models.Bike
{
    public class PartType
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public virtual ICollection<Part> Parts { get; set; }
    }
}