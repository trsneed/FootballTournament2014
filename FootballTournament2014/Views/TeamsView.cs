using System;
using Xamarin.Forms;
using FootballTournament2014.Common.Models;
using System.Linq;

namespace FootballTournament2014
{
    public class TeamsView : BaseView
    {
        private TeamsViewModel ViewModel { get{ return BindingContext as TeamsViewModel; } }
        public TeamsView()
        {
            BindingContext = new TeamsViewModel();

            var stack = new StackLayout {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(0, 0, 0, 8)
            };

            var activity = new ActivityIndicator {
                Color = Helpers.Color.DarkBlue.ToFormsColor(),
                IsEnabled = true
            };
            activity.SetBinding (ActivityIndicator.IsVisibleProperty, "IsBusy");
            activity.SetBinding (ActivityIndicator.IsRunningProperty, "IsBusy");

            stack.Children.Add (activity);
            var searchBar = new SearchBar();
            searchBar.TextChanged +=  (sender, e) => {
                ViewModel.FilterTeams(searchBar.Text);
            };
            var listView = new ListView();

            listView.ItemsSource = ViewModel.Teams;
            var cell = new DataTemplate(typeof(HorizontalListTextCell));

            cell.SetBinding (ImageCell.TextProperty, "Name");
            cell.SetBinding(ImageCell.DetailProperty, "Abbreviation");
            //            cell.SetBinding(ImageCell.ImageSourceProperty, "");

            listView.ItemTapped +=  (sender, args) => {
                if(listView.SelectedItem == null)
                    return;
                this.Navigation.PushAsync(new TeamDetailView(listView.SelectedItem as Team));
                listView.SelectedItem = null;
            };

            listView.ItemTemplate = cell;
            stack.Children.Add(searchBar);
            stack.Children.Add (listView);

            Content = stack;
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
            if (ViewModel == null || !ViewModel.CanLoadMore || ViewModel.IsBusy || ViewModel.Teams.Count > 0)
                return;

            ViewModel.LoadItemsCommand.Execute (null);

        }
    }
}

