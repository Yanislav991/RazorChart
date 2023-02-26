using RazorChart.Interfaces;

namespace RazorChart.Bar
{
    internal class BarChartSerie : IChartData
    {
        public string Color { get; set; }
        public decimal Value { get; set; }
        public string Category { get; set; }
    }
}
