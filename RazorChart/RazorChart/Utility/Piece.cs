using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorChart.Utility
{
    internal class Piece
    {
        public int Value { get; set; }
        public int Degrees { get; set; }
        public int StartsFrom { get; set; }
        public int GoesTo { get; set; }
    }
}
