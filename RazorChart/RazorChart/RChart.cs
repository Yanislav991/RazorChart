using RazorChart.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorChart
{
    public partial class RChart
    {
        public string ChartMarkup { get; set; }
        protected override void OnInitialized()
        {
            ChartMarkup = Calculate.Pie(radius:100, 1,2,3);
        }
    }
}
