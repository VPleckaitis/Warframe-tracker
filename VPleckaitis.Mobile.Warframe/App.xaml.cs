using System;
using VPleckaitis.Mobile.Warframe.Services;
using VPleckaitis.Mobile.Warframe.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VPleckaitis.Mobile.Warframe
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<AlertsDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
