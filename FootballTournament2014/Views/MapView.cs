using System;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace FootballTournament2014
{
    public class MapView : BaseView
    {
        private MapViewModel ViewModel
        {
            get { return BindingContext as MapViewModel; }
        }

        public MapView()
        {
            BindingContext = new MapViewModel();
            var stack = new StackLayout {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(0, 0, 0, 0)
            };

            var map = new Map(MapSpan.FromCenterAndRadius(new Position(-15, -50), 
                Distance.FromMiles(1100)));
            ViewModel.LoadPins().ForEach(m => map.Pins.Add(m));

            stack.Children.Add(map);
            Content = stack;
        }

      
    }
}

