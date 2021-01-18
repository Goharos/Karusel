using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Karusel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            var HolerikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text = "Holerik",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Image {Source = "Holerik.jpg"}
                    
                    }
                }
            };
            var SinvinikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text = "Sinvinik",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Image {Source = "Sinvinik"}
                    }
                }
            };
            var FlegmatikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text = "Flegmatik",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Image {Source = "Flegmatik"}
                    }
                }
            };
            var MelanholikContentPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                    new Label
                    {   Text = "Melanholik",
                        FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                        HorizontalOptions = LayoutOptions.Center
                    },
                    new Image {Source = "Melanholik"}
                    }
                }
            };
            private void app_Clicked(object sender, EventArgs e)
            {

            }

            Children.Add(HolerikContentPage);
            Children.Add(SinvinikContentPage);
            Children.Add(FlegmatikContentPage);
            Children.Add(MelanholikContentPage);
        }
    }
}
