using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using RazorChart.Interfaces;

namespace RazorChart.Pie.Pie
{
    public partial class Pie
    {
        [Inject]
        public IJSRuntime JS { get; set; }

        [Parameter]
        public IEnumerable<IChartData> Data { get; set; }

        [Parameter]
        public bool ShowLabels { get; set; }


        private IEnumerable<PieChartSerie> pieSerieList;

        protected override void OnInitialized()
        {
            pieSerieList = GeneratePie.PieSeries(Data.ToList());
            base.OnInitialized();
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && ShowLabels == true)
            {
                await JS.InvokeVoidAsync("insertLabels");
            }
        }
    }
}
