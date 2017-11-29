using System;
using TryLottie.Views;
using Xamarin.Forms;

namespace TryLottie
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new AnimationView();
            else
                MainPage = new NavigationPage(new AnimationView());
        }
    }
}