using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    public class CreateSmartContractSignedModel : Notifiable
    {
        public CreateSmartContractSignedModel(long smartContractId, long companyId, long customerId)
        {
            Id = 0;
            SmartContractId = smartContractId;
            CompanyId = companyId;
            CustomerId = customerId;

            AddNotifications(new Contract()
                .IsGreaterThan(SmartContractId, 0, nameof(SmartContractId), "O Id do contrato não pode ser igual a 0 (zero).")
                .IsGreaterThan(CompanyId, 0, nameof(CompanyId), "O Id da empresa não pode ser igual a 0 (zero).")
                .IsGreaterThan(CustomerId, 0, nameof(CustomerId), "O Id do cliente não pode ser igual a 0 (zero)."));
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
    }
}
