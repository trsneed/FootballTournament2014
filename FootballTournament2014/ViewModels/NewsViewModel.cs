using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using FootballTournament2014.Common.Models;
using FootballTournament2014.Common.Services;
using System.Net.Http;

namespace FootballTournament2014
{
    public class NewsViewModel : BaseViewModel
    {
        public NewsViewModel()
        {
            Title = "News";
        }

        private ObservableCollection<Headline> newsItems = new ObservableCollection<Headline>();

        /// <summary>
        /// gets or sets the news items
        /// </summary>
        public ObservableCollection<Headline> NewsItems
        {
            get { return newsItems; }
            set { newsItems = value; OnPropertyChanged("NewsItems"); }
        }

        private Headline selectedNewsItem;
        /// <summary>
        /// Gets or sets the selected news item
        /// </summary>
        public Headline SelectedNewsItem
        {
            get{ return selectedNewsItem; }
            set
            {
                selectedNewsItem = value;
                OnPropertyChanged("SelectedNewsItem");
            }
        }

        private Command loadItemsCommand;
        /// <summary>
        /// Command to load/refresh items
        /// </summary>
        public Command LoadItemsCommand
        {
            get { return loadItemsCommand ?? (loadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand())); }
        }

        private async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                using( var httpClient = new HttpClient())
                {
                    var feed = "http://api.espn.com/v1/sports/soccer/fifa.world/news?apikey=trs58u4j7gw4aat7ck8dsmgc";
                    var responseString = await httpClient.GetStringAsync(feed);

                    NewsItems.Clear();
                    var items = await ParseFeed(responseString);
                    foreach (var item in items)
                    {   
                        newsItems.Add(item);
                    }
                }
            } 
            catch (Exception) 
            {
                var page = new ContentPage();
                page.DisplayAlert("Error", "Unable to load News.", "OK", null);
            }

            IsBusy = false;
        }

        /// <summary>
        /// Parse the RSS Feed
        /// </summary>
        /// <param name="rss"></param>
        /// <returns></returns>
        private async Task<List<Headline>> ParseFeed(string rss)
        {
            return await Task.Run(() =>
            {
                return NewsService.GetNewsItems(rss);
            });
        }
    }
}

