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
        private List<Contract> contracts;
        private UserLogged user;
        private string typeUser;

        public CompanyViewModel()
        {
            Contracts = new List<Contract>();
            User = App.CurrentUser;

            TypeUser = User.TypeUser == Domain.Enums.ETypeUser.Customer ? "Cliente" : "Empresa";

            Contracts = ContractService.GetContracts();
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
