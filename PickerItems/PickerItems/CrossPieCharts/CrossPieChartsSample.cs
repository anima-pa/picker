using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossPieCharts.FormsPlugin.Abstractions
{
    /// <summary>
    /// Shows how to use the PieCharts controls.
    /// </summary>
    public class CrossPieChartSample
    {
        /// <summary>
        /// Makes a ContentPage with samples of PieCharts.
        /// </summary>
        /// <returns></returns>
        public ContentPage GetPageWithPieChart()
        {
            // The root page of your application
            var contentPage = new ContentPage
            {

                Content = new Grid
                {
                    Children =
                    {
                        new CrossPieChartView
                        {
                            Progress = 10,
                            ProgressColor = Color.Green,
                            ProgressBackgroundColor = Color.FromHex("#EEEEEEEE"),
                            StrokeThickness = Device.OnPlatform(10, 20, 80),
                            Radius = Device.OnPlatform(100, 180, 160),
                            BackgroundColor = Color.White
                        },
                        new Label
                        {
                            Text = "10%",
                            Font = Font.BoldSystemFontOfSize(NamedSize.Large),
                            FontSize = 70,
                            VerticalOptions = LayoutOptions.Center,
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor = Color.Black
                        }
                    }
                }
            };

            return contentPage;
        }
    }
}
