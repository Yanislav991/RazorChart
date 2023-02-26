using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RazorChart.Enums;
using RazorChart.Interfaces;
using RazorChart.Pie;


namespace RazorChart
{
    public partial class RChart
    {
        #region Parameters
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
        #endregion

        #region Lifecycle events
        protected override void OnInitialized()
        {
            PieSeries = CalculatePie.PieSeries(Data.ToList());
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if(firstRender && ShowLabels == true)
            {
                await JS.InvokeVoidAsync("insertLabels");
            }
        }
        #endregion

        #region Private Properties

        [Inject]
        public IJSRuntime JS { get; set; }
        private IEnumerable<PieChartSerie> PieSeries { get; set; }
        private IEnumerable<BarChartSerie> BarSeries { get; set; }
        #endregion
    }
}
