using System;

namespace Sirius.Domain.Entities
{
    /// <summary>
    /// Entidade Contrato Inteligente
    /// </summary>
    public class SmartContractEntity
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Título do contrato inteligente
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Descrição do contrato inteligente
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Motivos de rescisão do contrato.
        /// </summary>
        public string TerminationCondition { get; set; }

        /// <summary>
        /// Motivos de conclusão do contrato.
        /// </summary>
        public string ConclusionCondition { get; set; }

        /// <summary>
        /// Valor do contrato.
        /// </summary>
        public decimal Value { get; set; }

        /// <summary>
        /// Data de Criação do Registro
        /// </summary>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Data de Atualização do Registro
        /// </summary>
        public DateTime UpdatedOn { get; set; }

        /// <summary>
        /// Registro Apagado
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Inativo
        /// </summary>
        public bool Inactived { get; set; }

        /// <summary>
        /// Chave Estrangeira para Empresa
        /// </summary>
        public long CurrentCompanyEntityId { get; set; }

        /// <summary>
        /// Empresa dona do Contrato
        /// </summary>
        public CompanyEntity CompanyEntity { get; set; }
    }
}
