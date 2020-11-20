using MvvmHelpers;
using Sirius.Mobile.Models;
using Sirius.Mobile.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Mobile.ViewModels
{
    public class CustomerViewModel : BaseViewModel
    {
        private List<Contract> contracts;
        private UserResp user;
        private string typeUser;

        public CustomerViewModel()
        {
            Contracts = new List<Contract>();
            User = App.CurrentUser.user;

            TypeUser = User.typeUser == 0 ? "Cliente" : "Empresa";

            Contracts = ContractService.GetContracts();
        }

        public List<Contract> Contracts
        {
            get { return contracts; }
            set { SetProperty(ref contracts, value); }
        }

        public UserResp User
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
