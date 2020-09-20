using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Service
{
    /// <summary>
    /// Serviço do Contrato Inteligente
    /// </summary>
    public class SmartContractService
    {
        private static SmartContractRepository smartContractRepository;

        /// <summary>
        /// Construtor
        /// </summary>
        public SmartContractService(SiriusDbContext siriusDbContext)
        {
            smartContractRepository = new SmartContractRepository(siriusDbContext);
        }
    }
}
