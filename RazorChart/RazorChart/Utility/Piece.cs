using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorChart.Utility
{
    internal class Piece
    {
        public decimal Value { get; set; }
        public decimal Degrees { get; set; }
        public decimal StartsFrom { get; set; }
        public decimal GoesTo { get; set; }
    }
}
