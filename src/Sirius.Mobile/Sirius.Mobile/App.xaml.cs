using Sirius.Mobile.Models;
using Sirius.Mobile.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sirius.Mobile
{
    public partial class App : Application
    {
        public static UserLogged CurrentUser { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
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
