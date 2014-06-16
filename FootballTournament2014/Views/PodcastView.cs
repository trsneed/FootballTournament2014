using System;
using Xamarin.Forms;
using FootballTournament2014.Common.Models;

namespace FootballTournament2014
{
    public class PodcastView : BaseView
    {
        private PodcastViewModel ViewModel
        {
            get { return BindingContext as PodcastViewModel; }
        }
        public PodcastView()
        {
            BindingContext = new PodcastViewModel();

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

            var activity = new ActivityIndicator {
                Color = Helpers.Color.Greenish.ToFormsColor(),
                IsEnabled = true
            };
            activity.SetBinding (ActivityIndicator.IsVisibleProperty, "IsBusy");
            activity.SetBinding (ActivityIndicator.IsRunningProperty, "IsBusy");

            stack.Children.Add (activity);

            var listView = new ListView();

            listView.ItemsSource = ViewModel.Podcasts;

            var cell = new DataTemplate(typeof(ListTextCell));

            cell.SetBinding (TextCell.TextProperty, "Title");
            cell.SetBinding (TextCell.DetailProperty, "Details");

            listView.ItemTapped +=  (sender, args) => {
                if(listView.SelectedItem == null)
                    return;
                 
                this.Navigation.PushAsync(new PodcastDetalView(listView.SelectedItem as Podcast));
                listView.SelectedItem = null;
            };

            listView.ItemTemplate = cell;

            stack.Children.Add (listView);

            Content = stack;
        }


        protected override void OnAppearing ()
        {
            base.OnAppearing ();
            if (ViewModel == null || !ViewModel.CanLoadMore || ViewModel.IsBusy || ViewModel.Podcasts.Count > 0)
                return;

            ViewModel.LoadItemsCommand.Execute (null);

        }
    }
}

