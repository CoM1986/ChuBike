using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuBikeMVC.Models.Bike.Parts
{
    public class Handlebar
    {
        [Key]
        public int HandlebarId { get; set; }
        public double Rise { get; set; }
        public double Wide { get; set; }
        public double Backsweep { get; set; }
        public double Upsweep { get; set; }

        [ForeignKey("Part")]
        public int PartId { get; set; }
        public virtual Part Part { get; set; }
    }
}