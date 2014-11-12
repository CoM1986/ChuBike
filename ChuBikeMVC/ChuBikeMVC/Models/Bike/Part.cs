using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChuBikeMVC.Models.Bike;
using ChuBikeMVC.Models.Bike.Parts;

namespace ChuBikeMVC.Models
{
    public class Part
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public string AdditionalInformation { get; set; }

        public int ManufacturerId { get; set; }
        public virtual Manufacturer Manufacturer { get; set; }

        public int PartTypeId { get; set; }
        public virtual PartType PartType { get; set; }


        public virtual List<Frame> Frame { get; set; }
        public virtual List<Crank> Crank { get; set; }
        public virtual List<Rim> Rim { get; set; }
        public virtual List<Stem> Stem { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}