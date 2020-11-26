using MvvmHelpers;
using Sirius.Domain.Enums;
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
                var resp = LoginService.Logar(User.Username, User.Password);

                if (resp != null)
                {
                    App.CurrentUser = resp;

                    switch (resp.TypeUser)
                    {
                        case ETypeUser.Customer:
                            App.Current.MainPage = new NavigationPage(new Views.Customer.MainTabbedPage());
                            break;
                        case ETypeUser.Company:
                            App.Current.MainPage = new NavigationPage(new Views.Company.MainTabbedPage());
                            break;
                        case ETypeUser.Employee:
                            App.Current.MainPage.DisplayAlert("Ocorreu um erro...", "Login inválido", "Ok");
                            break;
                    }                        
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
