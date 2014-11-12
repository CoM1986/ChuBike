using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuBikeMVC.Models.Bike.Parts
{
    public class Frame
    {
        [Key]
        public int FrameId { get; set; }
        public double Lenght { get; set; }

        [ForeignKey("Part")]
        public int PartId { get; set; }
        public virtual Part Part { get; set; }
    }
}