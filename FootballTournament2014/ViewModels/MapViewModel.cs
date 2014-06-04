using System;
using Xamarin.Forms.Maps;
using System.Collections.Generic;
using System.Threading.Tasks;
using FootballTournament2014.Common.Services;

namespace FootballTournament2014
{
    public class MapViewModel : BaseViewModel
    {
        public MapViewModel()
        {
            Title = "Venues";
        }

        public List<Pin> LoadPins()
        {
            if (IsBusy)
                return new List<Pin>();

            IsBusy = true;

            var results = LocationService.GetLocations();
            var pins = new List<Pin>();
            results.ForEach(r => pins.Add(new Pin
            {
                Type = PinType.Place,
                Position = r.Position,
                Label = r.Title.ToString(),
                Address = r.City.ToString()
            }));
            return pins;  

            IsBusy = false;
        }
    }
}

