using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ChuBikeMVC.Models.Parts;

namespace ChuBikeMVC.Models.Context.Bike.Parts
{
    public class FramesDBContext : DbContext
    {
        public DbSet<Frame> Frames { get; set; }

        public System.Data.Entity.DbSet<ChuBikeMVC.Models.Part> Parts { get; set; }
    }
}