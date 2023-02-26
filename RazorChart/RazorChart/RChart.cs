using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RazorChart.Bar;
using RazorChart.Enums;
using RazorChart.Interfaces;
using RazorChart.Pie;


namespace RazorChart
{
    public partial class RChart
    {
        /// <summary>
        /// Specify the Width of the Chart.
        /// </summary>
        [Parameter]
        public string Width { get; set; } = "550px";

        /// <summary>
        /// The Chart Title Text
        /// </summary>
        [Parameter]
        public string Title { get; set; } = "Chart";

        /// <summary>
        /// Chart Data.
        /// </summary>
        [Parameter]
        public IEnumerable<IChartData> Data { get; set; }

        /// <summary>
        /// If true the labes are shown
        /// </summary>
        [Parameter]
        public bool ShowLabels { get; set; }

        /// <summary>
        /// Specify the Chart type.
        /// </summary>
        [Parameter]
        public ChartType Type { get; set; } = ChartType.Pie;
    }
}
