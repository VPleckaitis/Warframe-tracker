using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPleckaitis.Mobile.Warframe.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VPleckaitis.Mobile.Warframe.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            this.BindingContext = new LoginViewModel();
        }
    }
}