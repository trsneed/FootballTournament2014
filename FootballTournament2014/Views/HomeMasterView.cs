using System;
using Xamarin.Forms;
using FootballTournament2014.Common.Models;

namespace FootballTournament2014
{
    public class HomeMasterView : BaseView
    {
        private AboutView about;
        private NewsView news;
        private TeamsView teams;
        private MapView map;
        public Action<MenuType> PageSelectionChanged;
        private Page pageSelection;
        private MenuType menuType = MenuType.About;
        public Page PageSelection {
            get{ return pageSelection; }
            set { pageSelection = value; 
                if (PageSelectionChanged != null)
                    PageSelectionChanged (menuType);
            }
        }

        public HomeMasterView(HomeViewModel viewModel)
        {
            this.Icon = "slideout.png";
            BindingContext = viewModel;


            var layout = new StackLayout { Spacing = 0 };

            var label = new ContentView {
                Padding = new Thickness(10, 36, 0, 5),
                BackgroundColor = Color.Transparent,
                Content = new Label {
                    Text = "Menu",
                    Font = Font.SystemFontOfSize (NamedSize.Medium)
                }
            };

            layout.Children.Add(label);

            var listView = new ListView ();

            var cell = new DataTemplate(typeof(ListImageCell));

            cell.SetBinding (TextCell.TextProperty, HomeViewModel.TitlePropertyName);
            cell.SetBinding (ImageCell.ImageSourceProperty, "Icon");

            listView.ItemTemplate = cell;

            listView.ItemsSource = viewModel.MenuItems;
            if (news == null)
                news = new NewsView ();

            PageSelection = about;
            //Change to the correct page
            listView.ItemSelected += (sender, args) =>
            {
                var menuItem = listView.SelectedItem as MenuItem;
                menuType = menuItem.MenuType;
                switch(menuItem.MenuType){
                    case MenuType.About:
                        if(about == null)
                            about = new AboutView();

                        PageSelection = about;
                        break;
                    case MenuType.Groups:
                        break;
                    case MenuType.Knockout:
                        break;
                    case MenuType.Map:
                        if(map == null)
                            map =new MapView();
                        PageSelection = map;
                        break;
                    case MenuType.News:
                        if(news == null)
                            news = new NewsView();

                        PageSelection = news;
                        break;
                    case MenuType.Teams:
                        if(teams == null)
                            teams = new TeamsView();
                        PageSelection = teams;
                        break;
                }
            };

            listView.SelectedItem = viewModel.MenuItems[0];
            layout.Children.Add(listView);

            Content = layout;
        }
    }
}

