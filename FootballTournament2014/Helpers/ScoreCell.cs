using System;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class ScoreCell : ViewCell
    {

        public ScoreCell ()
        {
//            var homeLabel = new Label {
//                YAlign = TextAlignment.Center,
//                XAlign = TextAlignment.Start,
//            };
//            var homeScoreLabel = new Label {
//                YAlign = TextAlignment.Center,
//                XAlign = TextAlignment.Start,
//            };
//            homeLabel.SetBinding (Label.TextProperty, "HomeTeam");
//            homeScoreLabel.SetBinding(Label.TextProperty, "HomeScore");
//
//            var vLable = new Label
//            {
//                XAlign = TextAlignment.End,
//                YAlign = TextAlignment.Center,
//            };
//            var awayLabel = new Label {
//                YAlign = TextAlignment.Center,
//                XAlign = TextAlignment.End
//            };
//            var awayScoreLabel = new Label {
//                YAlign = TextAlignment.Center,
//                XAlign = TextAlignment.End,
//                HorizontalOptions = LayoutOptions.End,
//
//            };
//            vLable.Text = " vs. ";
//            awayLabel.SetBinding (Label.TextProperty, "AwayTeam");
//            awayScoreLabel.SetBinding(Label.TextProperty, "AwayScore");
//
//            var layout = new AbsoluteLayout {
//                Padding = new Thickness(5, 5, 5, 5),
//                HorizontalOptions = LayoutOptions.FillAndExpand,
//                VerticalOptions = LayoutOptions.FillAndExpand,
//                Children = {vLable}
//            };
////            layout.Children.Add(vLable);
////            layout.Children.Add(awayScoreLabel);
////            layout.Children.Add(awayLabel);
//          
//            View = layout;

            AbsoluteLayout absoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.Blue.WithLuminosity(0.9),
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            // Create two Labels for animating.
            var text1 = new Label 
            { 
                Text = "AbsoluteLayout",
                TextColor = Color.Black
            };
            absoluteLayout.Children.Add(text1);
            AbsoluteLayout.SetLayoutFlags(text1,
                AbsoluteLayoutFlags.PositionProportional);

            var text2 = new Label 
            { 
                Text = "AbsoluteLayout",
                TextColor = Color.Black,
                XAlign = TextAlignment.End
            };
            absoluteLayout.Children.Add(text2);
            AbsoluteLayout.SetLayoutFlags(text2,
                AbsoluteLayoutFlags.PositionProportional);

            View = absoluteLayout;
        }

//        protected override void OnBindingContextChanged ()
//        {
//            // Fixme : this is happening because the View.Parent is getting 
//            // set after the Cell gets the binding context set on it. Then it is inheriting
//            // the parents binding context.
//            View.BindingContext = BindingContext;
//            base.OnBindingContextChanged ();
//        }
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

