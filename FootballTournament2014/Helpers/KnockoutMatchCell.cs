using System;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class KnockoutMatchCell : ViewCell
    {
        public KnockoutMatchCell()
        {
            Grid grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = new GridLength(10, GridUnitType.Star) },
                    new ColumnDefinition
                    { Width = new GridLength(25, 
                        GridUnitType.Absolute)
                    }, 
                    new ColumnDefinition { Width = new GridLength(10, GridUnitType.Star)  },
                },

               
            };

            var homeLabel = new Label()
            {
                YAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(15),
            };
            var awayLabel = new Label()
            {
                YAlign = TextAlignment.Center,
                Font = Font.SystemFontOfSize(15),

            };
            var matchLabel = new Label()
            {
                TextColor = Color.Blue
            };
            homeLabel.SetBinding(Label.TextProperty, "HomeTeam");
            awayLabel.SetBinding(Label.TextProperty, "AwayTeam");
            matchLabel.SetBinding(Label.TextProperty, "KnockoutMatchName");
            grid.Children.Add(homeLabel,0,1);
            grid.Children.Add(new Label
            {
                Text = "vs.",
                YAlign = TextAlignment.Center,
            }, 1, 1);
            grid.Children.Add(awayLabel, 2, 1);

            this.View = grid;
        }
    }
}

