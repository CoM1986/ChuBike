using System.Data.Entity;
using ChuBikeMVC.Models.Bike;

namespace ChuBikeMVC.Models.Context
{
    public class PartContext : DbContext
    {
        public DbSet<Part> Parts { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<PartType> PartTypes { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}