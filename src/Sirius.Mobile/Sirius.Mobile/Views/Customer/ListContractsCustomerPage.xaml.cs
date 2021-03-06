﻿using Sirius.Mobile.ViewModels;
using Sirius.Mobile.Views.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sirius.Mobile.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListContractsCustomerPage : ContentPage
    {
        public ListContractsCustomerPage()
        {
            InitializeComponent();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new DetailContractSignedPage() { BindingContext = this.BindingContext });
        }
    }
}