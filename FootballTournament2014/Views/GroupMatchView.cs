using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class GroupMatchView:BaseView
    {
        public GroupMatchView()
        {

            var stack = new StackLayout {
                Orientation = StackOrientation.Vertical,
                Padding = new Thickness(0, 0, 0, 8)
            };

            stack.Children.Add(CreateListView());

            Content = stack;
        }

        ListView CreateListView()
        {
            var listView = new ListView {
                IsGroupingEnabled = true,
                GroupDisplayBinding = new Binding ("FirstInitial"),
                GroupShortNameBinding = new Binding ("FirstInitial")
            };

            var template = new DataTemplate (typeof (TextCell));
            template.SetBinding (TextCell.TextProperty, "FullName");
            template.SetBinding (TextCell.DetailProperty, "Address");

            listView.ItemTemplate = template;
            listView.ItemsSource = new[] {
                new Group ("C") {
                    new Person { FullName = "Caprice Nave" }
                },

                new Group ("J") {
                    new Person { FullName = "James Smith", Address = "404 Nowhere Street" },
                    new Person { FullName = "John Doe", Address = "404 Nowhere Ave" }
                }
            };

            return listView;
        }
    }

    class Person
    {
        public string FullName
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }
    }

    class Group : ObservableCollection<Person>
    {
        public Group (string firstInitial)
        {
            FirstInitial = firstInitial;
        }

        public string FirstInitial
        {
            get;
            private set;
        }
    }
}

