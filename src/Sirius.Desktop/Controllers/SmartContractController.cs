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
            return contract?.ToSmartContractView();
        }

        public void CreateSmartContract(CreateSmartContractModel createSmartContractModel) =>
            smartContractService.CreateSmartContract(createSmartContractModel);

        
    }
}
