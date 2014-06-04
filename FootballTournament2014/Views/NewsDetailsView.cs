using System;
using FootballTournament2014.Common.Models;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class NewsDetailsView : BaseView
    {
        public NewsDetailsView(Headline item)
        {
            BindingContext = item;
            var webView = new WebView ();
            webView.Source = new UrlWebViewSource {
                Url = item.Url
            };
            Content = webView;
        }
    }
}

