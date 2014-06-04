using System;
using FootballTournament2014.Common.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using FootballTournament2014.Common.Services;
using System.Net.Http;
using System.Net.Http;

namespace FootballTournament2014
{
    public class GroupMatchesViewModel : BaseViewModel
    {
        public GroupMatchesViewModel()
        {
        }

        private ObservableCollection<MatchDay> _matchDays;
        public ObservableCollection<MatchDay> MatchDays{ get; set; }

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
                List<MatchDay> listOMatches = new List<MatchDay>();
                using(var httpClient = new HttpClient())
                {
                    for (int i = 1; i <= 15; i++)
                    {
                        var feed = string.Format("http://footballdb.herokuapp.com/api/v1/event/world.2014/round/{0}",i);
                        var responseString = await httpClient.GetStringAsync(feed);
                        listOMatches.Add(MatchService.GetMatchDay(responseString));
                    }
                }
            } 
            catch (Exception ex) 
            {
                var page = new ContentPage();
                page.DisplayAlert ("Error", "Unable to load matches.", "OK", null);
            }

            IsBusy = false;
        }
    }
}

