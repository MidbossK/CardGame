using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FateAuction.Models
{
    public class Tarot
    {
        [Key]
        public int TarotID { get; set; }

        public string TarotName { get; set; }

        public int PointValue { get; set; }

        public string PictureURL { get; set; }
    }
}
