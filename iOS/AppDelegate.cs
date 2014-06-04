using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;

namespace FootballTournament2014.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow window;
        Page page;

        public override bool FinishedLaunching (UIApplication app, NSDictionary options)
        {
            window = new UIWindow (UIScreen.MainScreen.Bounds);
            UINavigationBar.Appearance.SetTitleTextAttributes(new UITextAttributes()
            {
                TextColor = UIColor.White
            });
            Forms.Init();
            Xamarin.FormsMaps.Init();
            page = FootballTournament2014.App.RootPage;
            window.RootViewController = page.CreateViewController ();

            window.MakeKeyAndVisible ();

            return true;
        }
    }
}

