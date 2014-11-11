using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChuBikeMVC.Models.Parts
{
    public class Steam
    {
        public int SteamId { get; set; }

        public double Govno { get; set; }

        public int PartId { get; set; }
        public virtual Part Part { get; set; }
    }
}