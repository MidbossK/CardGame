using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FateAuction.Models
{
    public class Cards
    {
        [Key]
        public int CardID { get; set; }

        public string Card { get; set; }

        public int PointValue { get; set; }

        public string PictureURL { get; set; }

    }
}
