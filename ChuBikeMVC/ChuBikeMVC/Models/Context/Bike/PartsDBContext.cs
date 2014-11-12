using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using ChuBikeMVC.Models.Bike;
using ChuBikeMVC.Models.Bike.Parts;

namespace ChuBikeMVC.Models.Context.Bike
{
    public class PartsDBContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<PartType> PartTypes { get; set; }

        public DbSet<Frame> Frames { get; set; }
        public DbSet<Crank> Cranks { get; set; }
        public DbSet<Rim> Rims { get; set; }
        public DbSet<Stem> Steams { get; set; }
        public DbSet<Fork> Forks { get; set; }
        public DbSet<Handlebar> Handlebars { get; set; }
        public DbSet<Pedal> Pedals { get; set; }
    }
}