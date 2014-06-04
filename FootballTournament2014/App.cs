using System;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class App
    {
        private static Page homeView;
        public static Page RootPage
        {
            get { return homeView ?? (homeView = new HomeView ()); }
        }
    }
}

