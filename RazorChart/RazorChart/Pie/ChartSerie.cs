using RazorChart.Interfaces;

namespace RazorChart.Pie
{
    public class PieChartSerie : IChartData
    {
        public string SerieDef { get; set; }
        public string Color { get; set; }
        public int Index { get; set; }
        public decimal Value { get; set; }
        public string Category { get; set; }
    }
}
