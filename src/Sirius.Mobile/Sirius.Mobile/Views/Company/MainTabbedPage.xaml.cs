using Sirius.Mobile.ViewModels;
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
    public partial class MainTabbedPage : TabbedPage
    {
        public MainTabbedPage()
        {
            var binding = new CompanyViewModel();

            InitializeComponent();

            BindingContext = binding;

            this.Children.Add(new InfoCompanyPage() { BindingContext = binding });
            this.Children.Add(new NewContractsPage() { BindingContext = binding });
        }
    }
}