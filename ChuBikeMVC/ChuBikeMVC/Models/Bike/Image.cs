using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChuBikeMVC.Models
{
    public class Image
    {
        public int Id { get; set; }
        public string Path { get; set; }

        public virtual Part Part { get; set; }
    }
}