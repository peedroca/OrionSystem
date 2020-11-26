using MvvmHelpers;
using Sirius.Mobile.Models;
using Sirius.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sirius.Mobile.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        private IEnumerable<ContractSignedView> contractSigneds;
        private List<Contract> contracts;
        private UserLogged user;
        private Contract selectedContract;
        private ContractSignedView selectedContractSigned;
        private string typeUser;

        public CustomerViewModel()
        {
            Contracts = new List<Contract>();
            User = App.CurrentUser;

            TypeUser = User.TypeUser == Domain.Enums.ETypeUser.Customer ? "Cliente" : "Empresa";

            UpdateContracts();

            SignContractCommand = new Command(SignContract);
            CancelSignContractCommand = new Command(CancelSignContract);
        }

        public IEnumerable<ContractSignedView> ContractSigneds
        {
            get { return contractSigneds; }
            set { SetProperty(ref contractSigneds, value); }
        }

        public List<Contract> Contracts
        {
            get { return contracts; }
            set { SetProperty(ref contracts, value); }
        }

        public Contract SelectedContract
        {
            get { return selectedContract; }
            set { selectedContract = value; }
        }
        
        public ContractSignedView SelectedContractSigned
        {
            get { return selectedContractSigned; }
            set { selectedContractSigned = value; }
        }

        public UserLogged User
        {
            get { return user; }
            set { SetProperty(ref user, value); }
        }

        public string TypeUser
        {
            get { return typeUser; }
            set { typeUser = value; }
        }

        public ICommand SignContractCommand { get; }
        public ICommand CancelSignContractCommand { get; }

        internal void SignContract()
        {
            try
            {
                ContractSignedService.SignContract(SelectedContract.CompanyView.Id, User.Id, SelectedContract.Id);

                App.Current.MainPage.DisplayAlert("Sirius", "Contrato assinado com sucesso", "OK");
                App.Current.MainPage.Navigation.PopAsync();

                UpdateContracts();
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        internal void CancelSignContract()
        {
            try
            {
                ContractSignedService.CancelSignContract(SelectedContractSigned.Id);

                App.Current.MainPage.DisplayAlert("Sirius", "Contrato cancelado com sucesso", "OK");
                App.Current.MainPage.Navigation.PopAsync();

                UpdateContracts();
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void UpdateContracts()
        {
            ContractSigneds = ContractSignedService.GetContractSigneds();

            var contracts = ContractService.GetContracts();

            foreach (var item in ContractSigneds)
            {
                contracts.RemoveAll(r => r.Id == item.IdContract);
            }

            Contracts = contracts;
        }
    }
}
