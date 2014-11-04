
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ChuBikeMVC.Models.Parts
{
    public class Frame
    {
        [Key, ForeignKey("Part")]
        public int Id { get; set; }

        public double Lenght { get; set; }

        public virtual Part Part { get; set; }
    }
}