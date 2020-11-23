using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sirius.API.Models
{
    /// <summary>
    /// Visualização de Contratos Inteligentes
    /// </summary>
    public class SmartContractView
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
        /// Empresa dona do Contrato
        /// </summary>
        public CompanyView CompanyView { get; set; }
    }
}
