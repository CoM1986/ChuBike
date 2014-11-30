using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuBikeMVC.Models.Bike.Parts
{
    [Table("Stem")]
    public class Stem : Part
    {
        //[Key]
        //public int SteamId { get; set; }
        public double Reach { get; set; }

        //[ForeignKey("Part")]
        //public int PartId { get; set; }
        //public virtual Part Part { get; set; }
    }
}