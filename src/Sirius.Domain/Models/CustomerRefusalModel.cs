using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    public class CustomerRefusalModel
    {
        public CustomerRefusalModel(long id, string refusalReason, DateTime createdon, DateTime updatedOn, bool rejected)
        {
            Id = id;
            RefusalReason = refusalReason;
            Createdon = createdon;
            UpdatedOn = updatedOn;
            Rejected = rejected;
        }

        /// <summary>
        /// Código da Recusa 
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Motivo de rejeição
        /// </summary>
        public string RefusalReason { get; }

        /// <summary>
        /// Data de criação
        /// </summary>
        public DateTime Createdon { get; }

        /// <summary>
        /// Data de atualização
        /// </summary>
        public DateTime UpdatedOn { get; }

        /// <summary>
        /// Rejeição revogada
        /// </summary>
        public bool Rejected { get; }
    }
}
