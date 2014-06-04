using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.Generic;
using FootballTournament2014.Common.Services;
using System.Collections.ObjectModel;
using System.Linq;
using FootballTournament2014.Common.Models;
using System.Net.Http;

namespace FootballTournament2014
{
    public class TeamsViewModel : BaseViewModel
    {
        public TeamsViewModel()
        {
            Title = "Teams";
        }

        private ObservableCollection<Team> _teams = new ObservableCollection<Team>();
        private List<Team> keepTeams = new List<Team>();
        /// <summary>
        /// gets or sets the news items
        /// </summary>
        public ObservableCollection<Team> Teams
        {
            get { return _teams; }
            set { _teams = value; OnPropertyChanged("Teams"); }
        }

        private Team selectedTeam;
        /// <summary>
        /// Gets or sets the selected news item
        /// </summary>
        public Team SelectedTeam
        {
            get{ return selectedTeam; }
            set
            {
                selectedTeam = value;
                OnPropertyChanged("SelectedTeam");
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

            try{
                var httpClient = new HttpClient();
                var feed = "http://api.espn.com/v1/sports/soccer/fifa.world/teams?apikey=trs58u4j7gw4aat7ck8dsmgc";
                var responseString = await httpClient.GetStringAsync(feed);

                Teams.Clear();
                var items = await ParseFeed(responseString);
                foreach (var item in items.OrderBy(t => t.Name))
                {
                    Teams.Add(item);
                }
                keepTeams = Teams.ToList();
            } catch (Exception ex) {
                var page = new ContentPage();
                page.DisplayAlert ("Error", "Unable to load teams.", "OK", null);
            }

            IsBusy = false;
        }

        /// <summary>
        /// Parse the RSS Feed
        /// </summary>
        /// <param name="rss"></param>
        /// <returns></returns>
        private async Task<List<Team>> ParseFeed(string json)
        {
            return await Task.Run(() =>
            {
                return TeamsService.GetTeams(json);
            });
        }

        public void FilterTeams(string text)
        {
            Teams.Clear();
            keepTeams.Where(t => t.Name.ToLower().Contains(text.ToLower())).ToList().ForEach(t => Teams.Add(t));
        }
    }
}

