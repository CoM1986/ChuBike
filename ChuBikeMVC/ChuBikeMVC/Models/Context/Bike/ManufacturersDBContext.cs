using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ChuBikeMVC.Models.Bike;

namespace ChuBikeMVC.Models.Context.Bike
{
    public class ManufacturersDBContext : DbContext
    {
        public DbSet<Manufacturer> Manufavturers { get; set; }
    }
}