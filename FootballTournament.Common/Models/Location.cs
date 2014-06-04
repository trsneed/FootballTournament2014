using System;
using Xamarin.Forms.Maps;

namespace FootballTournament2014.Common.Models
{
    public partial class Location : BaseModel
    {
        public Location()
        {
        }
        public string Url
        {
            get;
            set;
        }
        public string City { get; set; }
        public Position Position
        {
            get{ return new Position(this.Latitude, this.Longitude); }
        }
        public double Latitude
        {
            get;
            set;
        }
        public double Longitude
        {
            get;
            set;
        }
    }
}

