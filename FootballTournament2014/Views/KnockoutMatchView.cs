using System;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using FootballTournament2014.Common.Models;

namespace FootballTournament2014
{
    public class KnockoutMatchView : BaseView
    {
        private KnockoutMatchesViewModel ViewModel
        {
            get{ return BindingContext as KnockoutMatchesViewModel; }
        }

        public KnockoutMatchView()
        {
            BindingContext = new KnockoutMatchesViewModel();
            var refresh = new ToolbarItem {
                Command = ViewModel.LoadItemsCommand,
                Icon = "refresh.png",
                Name = "refresh",
                Priority = 0
            };
            ToolbarItems.Add (refresh);

            var stack = new StackLayout {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(0, 8, 0, 8)
            };

            var listView = new ListView ();

            listView.ItemsSource = ViewModel.KnockoutMatches;

            var cell = new DataTemplate(typeof(ListTextCell));

            cell.SetBinding (TextCell.TextProperty, "KnockoutMatchName");
            cell.SetBinding (TextCell.DetailProperty, "KnockoutMatchTeams");

            listView.ItemTemplate = cell;

            stack.Children.Add (listView);

            Content = stack;
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
            if (ViewModel == null || !ViewModel.CanLoadMore || ViewModel.IsBusy || ViewModel.KnockoutMatches.Count > 0)
                return;

            ViewModel.LoadItemsCommand.Execute (null);

        }
    }
}

