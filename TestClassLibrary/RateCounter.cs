using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TestClassLibrary
{
    public class RateCounter:ContentPage
    {
        public int RatingWidth(int Ratings)
        {
            int y = (width * Ratings) / 100;
            return y;
        }
        public Color StarColor(Color setColor)
        {
            Color starcolor = setColor;
            return starcolor;
        }
        public int hight { get; set; }
        public int width { get; set; }
        public StackLayout testpage(int result, Color scolor, string imageName = null)
        {
            var layout = new StackLayout();
            var layout1 = new AbsoluteLayout() { WidthRequest = width, HeightRequest = hight, BackgroundColor = Color.Black, HorizontalOptions = LayoutOptions.Start, Margin = 0, };
            var slayout = new StackLayout() { WidthRequest = RatingWidth(result), HeightRequest = hight, BackgroundColor = StarColor(scolor), HorizontalOptions = LayoutOptions.Start };
            AbsoluteLayout.SetLayoutBounds(slayout, new Rectangle(0f, 0f, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
            AbsoluteLayout.SetLayoutFlags(slayout, AbsoluteLayoutFlags.PositionProportional);

            var image = new Image { BackgroundColor = Color.Transparent };
            if (imageName == null)
            {
                image.Source = ImageSource.FromResource("TestClassLibrary.ratingTransparent.png");
            }
            else
            {
                image.Source = imageName;
            }

            AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0f, 0f, width, hight));
            AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.PositionProportional);
            layout1.Children.Add(slayout);
            layout1.Children.Add(image);
            layout.Children.Add(layout1);
            return layout;
        }
    }
}
