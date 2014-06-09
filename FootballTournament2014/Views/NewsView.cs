using System;
using Xamarin.Forms;
using FootballTournament2014.Common.Models;

namespace FootballTournament2014
{
    public class NewsView : BaseView
    {
        private NewsViewModel ViewModel
        {
            get { return BindingContext as NewsViewModel; }
        }
        public NewsView()
        {
            BindingContext = new NewsViewModel();

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

            var listView = new ListView ();

            listView.ItemsSource = ViewModel.NewsItems;

            var cell = new DataTemplate(typeof(ListTextCell));

            cell.SetBinding (TextCell.TextProperty, "headline");
            cell.SetBinding (TextCell.DetailProperty, "Title");

            listView.ItemTapped +=  (sender, args) => {
                if(listView.SelectedItem == null)
                    return;
                this.Navigation.PushAsync(new NewsDetailsView(listView.SelectedItem as Headline));
                listView.SelectedItem = null;
            };

            listView.ItemTemplate = cell;

            stack.Children.Add (listView);

            Content = stack;
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
            if (ViewModel == null || !ViewModel.CanLoadMore || ViewModel.IsBusy || ViewModel.NewsItems.Count > 0)
                return;

            ViewModel.LoadItemsCommand.Execute (null);

        }
    }
}

