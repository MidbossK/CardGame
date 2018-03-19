using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FateAuction.Models
{
    public class Tarot
    {
        public int TarotID { get; set; }

        public string TarotName { get; set; }

        public int PointValue { get; set; }

        public string PictureURL { get; set; }
    }
}
