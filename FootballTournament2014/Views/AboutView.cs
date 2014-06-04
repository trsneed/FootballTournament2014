using System;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class AboutView : BaseView
    {
        public AboutView()
        {
            var stack = new StackLayout {
                Orientation = StackOrientation.Vertical,
                Spacing = 10
            };
            var about = new Label {
                Font = Font.SystemFontOfSize (NamedSize.Medium),
                Text = "My name is Scott Hanselman. I'm a programmer, teacher, and speaker. I work out of my home office in Portland, Oregon for the Web Platform Team at Microsoft, but this blog, its content and opinions are my own. I blog about technology, culture, gadgets, diversity, code, the web, where we're going and where we've been. I'm excited about community, social equity, media, entrepreneurship and above all, the open web.",
                LineBreakMode = LineBreakMode.WordWrap
            };

            stack.Children.Add(about);

            Content = stack;
        }
    }
}

