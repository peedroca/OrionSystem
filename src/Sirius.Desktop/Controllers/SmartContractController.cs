using Microsoft.VisualBasic.Logging;
using Sirius.Desktop.Extesions;
using Sirius.Desktop.Models;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Desktop.Controllers
{
    class SmartContractController
    {
        private ISmartContractService smartContractService;

        public SmartContractController()
        {
            smartContractService = new SmartContractService(Settings.SiriusDbContext);
        }

        public IEnumerable<SmartContractViews> GetSmartContracts (long id , string title = null)
        {
            var contract = smartContractService.GetSmartContracts(id);

            if (id == 0)
            {
                contract = contract.Where(w => w.Id.Equals(id));
            }
            if (!string.IsNullOrEmpty(title))
            {
                contract = contract.Where(w => w.Title.ToLower().Contains(title.ToLower()));
            }
            return contract.ToSmartContractView();
        }

        public void CreateSmartContract(CreateSmartContractModel createSmartContractModel) =>
            smartContractService.CreateSmartContract(createSmartContractModel);
    }
}
