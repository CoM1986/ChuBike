using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChuBikeMVC.Models.Parts
{
    public class Crank
    {
        [Key]
        public int CrankId { get; set; }
        public double Width { get; set; }
        public double Diameter { get; set; }
        [ForeignKey("Part")]
        public int PartId { get; set; }
        public virtual Part Part { get; set; }
    }
}