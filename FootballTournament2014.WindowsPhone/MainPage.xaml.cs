using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using FootballTournament2014.WindowsPhone.Resources;
using Xamarin;
using Xamarin.Forms;

namespace FootballTournament2014.WindowsPhone
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            Forms.Init();
            FormsMaps.Init();

            Content = FootballTournament2014.App.RootPage.ConvertPageToUIElement(this);
        }
    }
}