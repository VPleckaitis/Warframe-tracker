using System;
using System.Collections.Generic;
using System.ComponentModel;
using VPleckaitis.Mobile.Warframe.Models;
using VPleckaitis.Mobile.Warframe.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VPleckaitis.Mobile.Warframe.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}