using MvvmHelpers;
using Sirius.Mobile.Models;
using Sirius.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Mobile.ViewModels
{
    public class CompanyViewModel : BaseViewModel
    {
        private IEnumerable<ContractSignedView> contractSigneds;
        private List<Contract> contracts;
        private UserLogged user;
        private string typeUser;

        public CompanyViewModel()
        {
            Contracts = new List<Contract>();
            User = App.CurrentUser;

            TypeUser = User.TypeUser == Domain.Enums.ETypeUser.Customer ? "Cliente" : "Empresa";

            Contracts = ContractService.GetContracts();
            ContractSigneds = ContractSignedService.GetContractSigneds();
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

    }
}
