using System;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class ScoreCell : ViewCell
    {

        public ScoreCell ()
        {
            var homeLabel = new Label {
                YAlign = TextAlignment.Center
            };
            var homeScoreLabel = new Label {
                YAlign = TextAlignment.Center
            };
            homeLabel.SetBinding (Label.TextProperty, "HomeTeam");
            homeScoreLabel.SetBinding(Label.TextProperty, "HomeScore");
            var layout = new StackLayout {
                Padding = new Thickness(5, 0, 5, 0),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                Children = {homeLabel,homeScoreLabel}
            };

            var awayLabel = new Label {
                YAlign = TextAlignment.Center
            };
            var awayScoreLabel = new Label {
                YAlign = TextAlignment.Center
            };
            awayLabel.SetBinding (Label.TextProperty, "AwayTeam");
            awayScoreLabel.SetBinding(Label.TextProperty, "AwayScore");
            layout.Children.Add(awayLabel);
            layout.Children.Add(awayScoreLabel);
            View = layout;
        }

        protected override void OnBindingContextChanged ()
        {
            // Fixme : this is happening because the View.Parent is getting 
            // set after the Cell gets the binding context set on it. Then it is inheriting
            // the parents binding context.
            View.BindingContext = BindingContext;
            base.OnBindingContextChanged ();
        }
//        public ScoreCell()
//        {
//            View = new StackLayout
//            {
//                Orientation = StackOrientation.Horizontal,
//                Children =
//                {
//                    new Label
//                    {
//                        Text = HomeTeam ?? "" + ": ",
//                        TextColor = Color.Black,
//                    },
////                    new Label
////                    {
////                        Text = HomeTeamScore.ToString()  ,
////                        TextColor = Color.Black,
////                    },
//                    new Label
//                    { Text = " v. "
//                    },
////                    new Label
////                    {
////                        Text = AwayTeamScore.ToString(),
////                        TextColor = Color.Black,
////                    },
//                    new Label
//                    {
//                        Text = " :"+AwayTeam ?? "",
//                        TextColor = Color.Black,
//                    },
////                    new Label
////                    {
////                        Text = string.Format("{0} - {1}", HomeScore ?? 0, AwayScore ?? 0)
////                    },
////                    new Label
////                    {
////                        Text = AwayTeam
////                    }
//                }
//            };
//        }
//
//        public static readonly BindableProperty HomeTeamProperty = 
//            BindableProperty.Create<ScoreCell, string>(h => h.HomeTeam, default(string));
//       
//
//        public string HomeTeam
//        {
//            get{ return (string)GetValue(HomeTeamProperty); }
//            set{ SetValue(HomeTeamProperty, value); }
//        }
//
//        public static readonly BindableProperty AwayTeamProperty = 
//            BindableProperty.Create<ScoreCell, string>(h => h.AwayTeam, default(string));
//
//
//        public string AwayTeam
//        {
//            get{ return (string)GetValue(AwayTeamProperty); }
//            set{ SetValue(AwayTeamProperty, value); }
//        }

//        public static readonly BindableProperty AwayTeamScoreProperty = 
//            BindableProperty.Create<ScoreCell,string>(h => h.AwayTeamScore , default(string));
//
//
//        public string AwayTeamScore
//        {
//            get{ return (string)GetValue(AwayTeamScoreProperty); }
//            set{ SetValue(AwayTeamScoreProperty, value); }
//        }
//
//        public static readonly BindableProperty HomeTeamScoreProperty = 
//            BindableProperty.Create<ScoreCell, string>(h => h.HomeTeamScore ?? "0", default(string));
//
//
//        public string HomeTeamScore
//        {
//            get{ return (string)GetValue(HomeTeamScoreProperty); }
//            set{ SetValue(HomeTeamScoreProperty, value); }
//        }
    }
}

