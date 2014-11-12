using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuBikeMVC.Models.Bike.Parts
{
    public class Fork
    {
        [Key]
        public int ForkId { get; set; }
        public double Offset { get; set; }
        public double Diametr { get; set; }

        [ForeignKey("Part")]
        public int PartId { get; set; }
        public virtual Part Part { get; set; }
    }
}