using System;
using Xamarin.Forms;
using System.Collections.Generic;
using FootballTournament2014.Common.Models;

namespace FootballTournament2014
{
    public class HomeView : MasterDetailPage
    {
        private HomeViewModel ViewModel 
        {
            get { return BindingContext as HomeViewModel; }
        }
        HomeMasterView master;
        private Dictionary<MenuType, NavigationPage> pages;
        public HomeView()
        {
            pages = new Dictionary<MenuType, NavigationPage> ();
            BindingContext = new HomeViewModel ();

            Master = master = new HomeMasterView (ViewModel);

            var homeNav = new NavigationPage(master.PageSelection) {
                Tint = Helpers.Color.Greenish.ToFormsColor()
            };

            Detail = homeNav;

            pages.Add (MenuType.News, homeNav);

            master.PageSelectionChanged = (menuType) => {

                NavigationPage newPage;
                if(pages.ContainsKey(menuType)){
                    newPage = pages[menuType];
                }
                else{
                    newPage = new NavigationPage(master.PageSelection){
                        Tint = Helpers.Color.Greenish.ToFormsColor()
                    };
                    pages.Add (menuType, newPage);
                }
                Detail = newPage;
                Detail.Title = master.PageSelection.Title;
                IsPresented = false;
            };

            this.Icon = "slideout.png";
        }
    }
}

