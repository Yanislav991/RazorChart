using Microsoft.AspNetCore.Components;
using RazorChart.Interfaces;

namespace RazorChart.Bar.Bar
{
    public partial class Bar
    {
        [Parameter]
        public IEnumerable<IChartData> Data { get; set; }

        private decimal greatestValue { get; set; }

        private decimal yStep { get; set; }
        private List<BarRect> barSerieList { get; set; }

        private List<string> Categories { get; set; }
        protected override void OnInitialized()
        {
            Categories = Data.Select(x=>x.Category).ToList();
            greatestValue = Data.OrderByDescending(x => x.Value).FirstOrDefault().Value;
            barSerieList = GenerateBar.BarRect(Data.ToList(), greatestValue).ToList();
            yStep = greatestValue / 8;

            base.OnInitialized();
        }
    }
}
