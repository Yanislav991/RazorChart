using RazorChart.Bar.Bar;
using RazorChart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazorChart.Bar
{
    internal static class GenerateBar
    {
        internal static IEnumerable<BarRect> BarRect(List<IChartData> chartDatas, decimal maxVal)
        {
            return chartDatas.Select(x => new BarRect
            {
                Height = x.Value / maxVal * 450,
                YCoord = 450 - (x.Value / maxVal * 450),
                Color = x.Color
            }) ;
        }
    }
}
