using System.ComponentModel;
using VPleckaitis.Mobile.Warframe.ViewModels;
using Xamarin.Forms;

namespace VPleckaitis.Mobile.Warframe.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}