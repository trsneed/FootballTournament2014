using System;
using System.Collections.ObjectModel;
using FootballTournament2014.Common.Models;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Net.Http;
using System.Collections.Generic;
using FootballTournament.Common.Services;

namespace FootballTournament2014
{
    public class PodcastViewModel : BaseViewModel
    {

        public PodcastViewModel()
        {
            Title = "World Cup Football Daily";
        }

        private ObservableCollection<Podcast> podcasts = new ObservableCollection<Podcast>();

        public ObservableCollection<Podcast> Podcasts
        {
            get { return podcasts; }
            set { podcasts = value; OnPropertyChanged("Podcasts"); }
        }
        private Podcast selectedPodcast;
       
        public Podcast SelectedPodcast
        {
            get{ return selectedPodcast; }
            set
            {
                selectedPodcast = value;
                OnPropertyChanged("SelectedPodcast");
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
                    var feed = "http://www.theguardian.com/football/series/footballweekly/rss";
                    var responseString = await httpClient.GetStringAsync(feed);

                    Podcasts.Clear();
                    var items = await ParseFeed(responseString);
                    foreach (var item in items)
                    {   
                        podcasts.Add(item);
                    }
                }
            } 
            catch (Exception) 
            {
                var page = new ContentPage();
                    page.DisplayAlert("Error", "Unable to load Pods.", "OK", null);
            }

            IsBusy = false;
        }

        private async Task<List<Podcast>> ParseFeed(string rss)
        {
            return await Task.Run(() =>
            {
                return PodcastService.ParsePodcastRss(rss);
            });
        }
    }
}

