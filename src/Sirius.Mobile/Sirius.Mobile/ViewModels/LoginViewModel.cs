using MvvmHelpers;
using Sirius.Mobile.Models;
using Sirius.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sirius.Mobile.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private User user;

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
            User = new User();
        }

        public User User
        {
            get { return user; }
            set { SetProperty(ref user, value); }
        }

        public ICommand LoginCommand { get; set; }

        void Login() 
        {
            string resp = LoginService.Logar(User);

            App.Current.MainPage.DisplayAlert("Login"
                , resp
                , "OK");
        }
    }
}
