using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Entities
{
    public class SmartContractSignedEntity
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long  Id { get; set; }

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
        public long  CustomerId { get; set; }

        /// <summary>
        /// Data de criação
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Data de atualização
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Cancelado
        /// </summary>
        public bool Canceled { get; set; }


    }
}
