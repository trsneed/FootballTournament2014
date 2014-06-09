using System;
using System.Threading.Tasks;
using FootballTournament2014.Common.Models;
using System.Collections.Generic;
using FootballTournament2014.Common.Services;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace FootballTournament2014
{
    public class KnockoutMatchesViewModel : BaseViewModel
    {
        public KnockoutMatchesViewModel()
        {
            Title = "Knockout Stage";
        }
       
        private ObservableCollection<KnockoutMatch> knockoutMatches = new ObservableCollection<KnockoutMatch>();

        /// <summary>
        /// gets or sets the news items
        /// </summary>
        public ObservableCollection<KnockoutMatch> KnockoutMatches
        {
            get { return knockoutMatches; }
            set { knockoutMatches = value; OnPropertyChanged("KnockoutMatches"); }
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
                await Task.Run(() => 
                {
                    KnockoutMatches.Clear();
                    var result = MatchService.GetKnockoutMatches();

                    foreach (var item in result) {
                        KnockoutMatches.Add(item);
                    }
                }); 
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

