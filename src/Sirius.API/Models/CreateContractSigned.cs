using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sirius.API.Models
{
    public class CreateContractSigned
    {
        /// <summary>
        /// Identificação do Contrato Inteligente
        /// </summary>
        public long SmartContractId { get; set; }

        /// <summary>
        /// Identificação da empresa.
        /// </summary>
        public long CompanyId { get; set; }

        /// <summary>
        /// Identificação do Cliente
        /// </summary>
        public long CustomerId { get; set; }
    }
}
