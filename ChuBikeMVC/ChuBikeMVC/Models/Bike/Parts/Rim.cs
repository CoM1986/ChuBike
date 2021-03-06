﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuBikeMVC.Models.Bike.Parts
{
    public class Rim
    {
        [Key]
        public int RimId { get; set; }
        public double Size { get; set; }
        public int NumOfSpokes { get; set; }
        
        [ForeignKey("Part")]
        public int PartId { get; set; }
        public virtual Part Part { get; set; }
    }
}