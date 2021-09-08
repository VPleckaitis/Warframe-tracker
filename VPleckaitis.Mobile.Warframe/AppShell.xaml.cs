using System;
using System.Collections.Generic;
using VPleckaitis.Mobile.Warframe.ViewModels;
using VPleckaitis.Mobile.Warframe.Views;
using Xamarin.Forms;

namespace VPleckaitis.Mobile.Warframe
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
