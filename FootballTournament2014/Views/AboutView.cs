using System;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class AboutView : BaseView
    {
        public AboutView()
        {
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions = 
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
                },
                ColumnDefinitions = 
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) }
                }
            };

            grid.Children.Add(new Label
            {
                Text = "Proudly Built With Xamarin.Forms",
                BackgroundColor = Helpers.Color.Greenish.ToFormsColor(),
                TextColor = Color.White,
                Font = Font.BoldSystemFontOfSize(20),
                HorizontalOptions = LayoutOptions.Center
            }, 0, 3, 0, 1);

            grid.Children.Add(new Label
            {
                Text = "trsneed.com",
                BackgroundColor = Helpers.Color.Greenish.ToFormsColor(),
                TextColor = Color.White,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            }, 0, 1);

            grid.Children.Add(new BoxView
            {
                Color = Color.Silver,
                HeightRequest = 0
            }, 1, 1);

            grid.Children.Add(new Label
            {   Text = "https://github.com/trsneed/FootballTournament2014",
                BackgroundColor = Helpers.Color.Greenish.ToFormsColor(),
                TextColor = Color.White,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            }, 0, 2);

            grid.Children.Add(new Label
            {
                Text = "Leftover space",
                BackgroundColor = Helpers.Color.Greenish.ToFormsColor(),
                TextColor = Color.White,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            }, 1, 2);

            grid.Children.Add(new Label
            {
                Text = "https://github.com/trsneed/FootballTournament2014",
                BackgroundColor = Helpers.Color.Greenish.ToFormsColor(),
                TextColor = Color.White,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,

            }, 2, 3, 1, 3);

            grid.Children.Add(new Label
            {
                Text = "News and Teams by ESPN",
                BackgroundColor = Helpers.Color.Greenish.ToFormsColor(),
                TextColor = Color.White,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center
            }, 0, 2, 3, 4);

            grid.Children.Add(new Label
            {
                Text = "Matches by FootballDB",
                BackgroundColor = Helpers.Color.Greenish.ToFormsColor(),
                TextColor = Color.White,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center
            }, 2, 3);

            // Accomodate iPhone status bar.
            this.Padding = new Thickness(10, Device.OnPlatform(10, 0, 0), 10, 5);

            // Build the page.
            this.Content = grid;
        
        }
    }
}

