using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    public class SmartContractSignedModel
    {
        public SmartContractSignedModel(long id, long smartContractId, long companyId, long customerId, DateTime createdOn, DateTime updatedOn, bool canceled)
        {
            Id = id;
            SmartContractId = smartContractId;
            CompanyId = companyId;
            CustomerId = customerId;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            Canceled = canceled;
        }

        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Identificação do Contrato Inteligente
        /// </summary>
        public long SmartContractId { get; }

        /// <summary>
        /// Identificação da empresa.
        /// </summary>
        public long CompanyId { get; }

        /// <summary>
        /// Identificação do Cliente
        /// </summary>
        public long CustomerId { get; }

        /// <summary>
        /// Data de criação
        /// </summary>
        public DateTime CreatedOn { get; }

        /// <summary>
        /// Data de atualização
        /// </summary>
        public DateTime UpdatedOn { get; }

        /// <summary>
        /// Cancelado
        /// </summary>
        public bool Canceled { get; }
    }
}
