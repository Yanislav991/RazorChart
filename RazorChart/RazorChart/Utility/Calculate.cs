﻿namespace RazorChart.Utility
{
    public static class Calculate
    {
        private static Random rand = new Random();
        public static IEnumerable<ChartSerie> Pie(int radius = 100, params int[] values)
        {
            var paths = new List<ChartSerie>();
            var total = values.Aggregate(0, (a, b) => a + b);
            var data = values.Select(v => new Piece()
            {
                Value = v,
                Degrees = (decimal)v / total * 360
            }).ToList();

            foreach (var item in data.Select((value, i) => new { i, value }))
            {
                var value = item.value;
                var index = item.i;

                if (index == 0)
                {
                    value.StartsFrom = 0;
                    value.GoesTo = value.Degrees;
                }
                else
                {
                    value.StartsFrom = data[index - 1].GoesTo;
                    value.GoesTo = value.StartsFrom + value.Degrees;
                }
                paths.Add(new ChartSerie()
                {
                    Color = Color(),
                    Index = index,
                    SerieDef = PathDefinition(radius, value.StartsFrom, value.GoesTo)
                });
            }
            return paths;
        }

        private static string SvgPie(int width, string content)
        {
            return $"<svg viewBox=\"0 0 {width} {width}\"><g class='sectors'>{content}</g></svg>";
        }

        private static string Path(string definition, int index)
        {
            return $"<path d ='{definition}' class='type${index}' fill='{Color()}'/>";
        }

        private static string PathDefinition(int radius, decimal startAngle, decimal endAngle)
        {
            bool IsCircle = endAngle - startAngle == 360;
            if (IsCircle)
            {
                endAngle--;
            }

            var start = PolarToCartesian(radius, startAngle);
            var end = PolarToCartesian(radius, endAngle);

            var largeArcFlag = endAngle - startAngle <= 180 ? 0 : 1;

            var definition = $"M {start.X} {start.Y} A {radius} {radius} 0 {largeArcFlag} 1 {end.X} {end.Y}";

            if (IsCircle)
            {
                definition += " Z";
            }
            else
            {
                definition += $" L {radius} {radius}, L {start.X} {start.Y} Z";
            }
            return definition;
        }

        private static Point PolarToCartesian(decimal radius, decimal angleInDegrees)
        {
            var radians = (angleInDegrees - 90) * (decimal)Math.PI / 180;
            return new Point
            {
                X = (int)Math.Round(radius + (radius * (decimal)Math.Cos((double)radians))),
                Y = (int)Math.Round(radius + (radius * (decimal)Math.Sin((double)radians)))
            };
        }
        private static string Color()
        {
            return String.Format("#{0:X6}", rand.Next(0x1000000));
        }
    }

}
