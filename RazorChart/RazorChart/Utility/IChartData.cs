using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorChart.Utility
{
    public interface IChartData
    {
        public string Color { get; set; }
        public decimal Value { get; set; }
        public string Category { get; set; }

    }
}
