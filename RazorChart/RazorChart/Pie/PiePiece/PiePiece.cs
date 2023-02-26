using Microsoft.AspNetCore.Components;

namespace RazorChart.Pie.PiePiece
{
    public partial class PiePiece
    {
        [Parameter]
        public string Index { get; set; }

        [Parameter]
        public string Definition { get; set; }

        [Parameter]
        public string Category { get; set; }

        [Parameter]
        public string Value { get; set; }

        [Parameter]
        public string Color { get; set; }
    }
}
