using Flunt.Notifications;
using Flunt.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    public class UpdateSmartContractSignedModel : Notifiable
    {
        public UpdateSmartContractSignedModel(long id, long smartContractId, long companyId, long customerId, DateTime createdOn, bool canceled)
        {
            Id = id;
            SmartContractId = smartContractId;
            CompanyId = companyId;
            CustomerId = customerId;
            CreatedOn = createdOn;
            Canceled = canceled;

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

        /// <summary>
        /// Data de criação
        /// </summary>
        public DateTime CreatedOn { get; }

        /// <summary>
        /// Cancelado
        /// </summary>
        public bool Canceled { get; }
    }
}
