using System;
using Xamarin.Forms;

namespace FootballTournament2014
{
    public class BaseView : ContentPage
    {
        public BaseView ()
        {
            SetBinding (Page.TitleProperty, new Binding(BaseViewModel.TitlePropertyName));
            SetBinding (Page.IconProperty, new Binding(BaseViewModel.IconPropertyName));
        }
    }
}

