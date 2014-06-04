using System;
using FootballTournament2014.Common.Models;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class TeamDetailView : BaseView
    {
        public TeamDetailView(Team item )
        {
            BindingContext = item;
            var webView = new WebView ();
            webView.Source = new UrlWebViewSource {
                Url = item.Links.web.teams.href
            };
            Content = webView;
        }
    }
}

