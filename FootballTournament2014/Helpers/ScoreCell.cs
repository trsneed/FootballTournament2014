using System;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class ScoreCell : ViewCell
    {

        public ScoreCell ()
        {
            Grid grid = new Grid
            {
                Padding = new Thickness(5, 10, 0, 0),
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(10, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
                    new ColumnDefinition
                    { Width = new GridLength(25, 
                            GridUnitType.Absolute)
                    }, 
                    new ColumnDefinition { Width = new GridLength(2, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(10, GridUnitType.Star)  },
                },
            };

            var homeLabel = new Label()
            {
                YAlign = TextAlignment.Center,
                XAlign = TextAlignment.End
            };
            var awayLabel = new Label()
            {
                YAlign = TextAlignment.Center
            };
            var homeScore = new Label()
            {
                YAlign = TextAlignment.Center,
                XAlign = TextAlignment.End
            };
            var awayScore = new Label()
            {
                YAlign = TextAlignment.Center
            };
            homeLabel.SetBinding(Label.TextProperty, "HomeTeam");
            awayLabel.SetBinding(Label.TextProperty, "AwayTeam");
            homeScore.SetBinding(Label.TextProperty, "HomeScore");
            awayScore.SetBinding(Label.TextProperty, "AwayScore");

            grid.Children.Add(homeLabel);
            
            grid.Children.Add(homeScore, 1, 0);
            grid.Children.Add(new Label
            {
                Text = "vs.",
                YAlign = TextAlignment.Center,
            }, 2, 0);
            grid.Children.Add(awayScore, 3, 0);
            grid.Children.Add(awayLabel, 4, 0);
            

            this.View = grid;
            this.View.HorizontalOptions = LayoutOptions.Center;
        }
    }
}

