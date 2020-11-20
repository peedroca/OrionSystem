using MvvmHelpers;
using Sirius.Mobile.Models;
using Sirius.Mobile.Services;
using Sirius.Mobile.Views;
using Sirius.Mobile.Views.Customer;
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
            try
            {
                var resp = LoginService.Logar(User);

                if (resp != null)
                {
                    App.CurrentUser = resp;

                    if(resp.user.typeUser == 0) // É cliente
                        App.Current.MainPage = new NavigationPage(new Views.Customer.MainTabbedPage());
                    else // É empresa
                        App.Current.MainPage = new NavigationPage(new Views.Company.MainTabbedPage());
                }
                else
                {
                    App.Current.MainPage.DisplayAlert("Ocorreu um erro...", "Login inválido", "Ok");
                }
            }
            catch (Exception e)
            {
                App.Current.MainPage.DisplayAlert("Ocorreu um erro...", e.Message, "Ok");
            }
        }
    }
}
