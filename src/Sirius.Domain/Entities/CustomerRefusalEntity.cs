using System;

namespace Sirius.Domain.Entities
{
    /// <summary>
    /// Entidade de Recusa do Cliente
    /// </summary>
    public class CustomerRefusalEntity
    {
        /// <summary>
        /// Código da Recusa 
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Motivo de rejeição
        /// </summary>
        public string RefusalReason { get; set; }

        /// <summary>
        /// Data de criação
        /// </summary>
        public DateTime Createdon { get; set; }

        /// <summary>
        /// Data de atualização
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Rejeição revogada
        /// </summary>
        public bool Repealed { get; set; }
    }
}