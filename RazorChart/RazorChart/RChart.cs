using Microsoft.AspNetCore.Components;
using RazorChart.Utility;

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

        [Parameter]
        public IEnumerable<IChartData> Data { get; set; }
        #endregion

        #region Lifecycle events
        protected override void OnInitialized()
        {
            Series = Calculate.PieSeries(Data.ToList());
        }
        #endregion

        #region Private Properties
        private IEnumerable<ChartSerie> Series { get; set; }
        #endregion
    }
}
