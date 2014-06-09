using System;
using FootballTournament2014.Common.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using FootballTournament2014.Common.Services;
using System.Net.Http;
using System.Linq;

namespace FootballTournament2014
{
    public class GroupMatchesViewModel : BaseViewModel
    {
        public GroupMatchesViewModel()
        {
            Title = "Group Rounds";
        }
        public EventHandler ItemsLoaded;
        public List<Match> Result = new List<Match>();
        //This dont work 
//        private List<GroupHelper> groupMatches = new List<GroupHelper>();
//        public List<GroupHelper> GroupMatches{ 
//            get { return groupMatches; }
//            set { groupMatches = value; OnPropertyChanged("GroupMatches"); }
//        }

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
                Result.Clear();
                using(var httpClient = new HttpClient())
                {
                    for (int i = 1; i <= 15; i++)
                    {
                        var feed = string.Format("http://footballdb.herokuapp.com/api/v1/event/world.2014/round/{0}",i);
                        var responseString = await httpClient.GetStringAsync(feed);
                        Result.AddRange(MatchService.GetMatchDay(responseString));
                    }

                    foreach(var item in Result)
                    {
                        item.HomeScore = (item.HomeScore == "" || item.HomeScore == null) ?
                            "0" : item.HomeScore;
                        item.AwayScore = (item.AwayScore == "" || item.AwayScore == null) ?
                            "0" : item.AwayScore;
                    }
                }
                this.ItemsLoaded(this, new EventArgs());
            } 
            catch (Exception ex) 
            {
                var page = new ContentPage();
                page.DisplayAlert ("Error", "Unable to load matches.", "OK", null);
            }

            IsBusy = false;
        }
        //This is out because I was getting an argumentoutofrangeexception moving some logic to the view :)
//        private async Task StageTheGroups(List<Match> matches)
//        {
//            await Task.Run(() =>
//            {
//                foreach (var date in matches.Select(p => p.MatchDate).Distinct())
//                {
//                    GroupMatches.Add(new GroupHelper(date));
//                }
//
//                foreach (var matchDay in GroupMatches)
//                {
//                    matches.Where(m => m.MatchDate == matchDay.Date).ToList()
//                     .ForEach(m => matchDay.Add(m));
//                }
//                this.ItemsLoaded(this, new EventArgs());
//            });
//        }
    }
}

