using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ChuBikeMVC.Models.Bike;

namespace ChuBikeMVC.Models.Context.Bike
{
    public class PartTypesDBContext : DbContext
    {
        public DbSet<PartType> PartTypes { get; set; }
    }
}