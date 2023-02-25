using Microsoft.AspNetCore.Components;
using RazorChart.Utility;

namespace RazorChart
{
    public partial class RChart
    {
        private List<ChartSerie> Series { get; set; }
        [Parameter]
        public string Width { get; set; } = "500px";
        protected override void OnInitialized()
        {
            Series = Calculate.Pie(radius:100, 5, 2, 3, 4).ToList();
        }
    }
}
