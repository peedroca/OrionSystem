using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sirius.Mobile.Views.Company
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
            App.Current.MainPage.Navigation.PushAsync(new DetailContractPage() { BindingContext = e.SelectedItem });
        }
    }
}