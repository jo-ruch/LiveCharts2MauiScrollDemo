using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace LiveCharts2ScrollDemo
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();

            MyChart.Series = new ISeries[]
            {
                new LineSeries<int>
                {
                    Values = new int[] { 4, 6, 5, 3, -3, -1, 2, 4, 6, 5, 3, -3, -1, 2, 4, 6, 5, 3, -3, -1, 2 }
                }
            };
        }

    }

}
