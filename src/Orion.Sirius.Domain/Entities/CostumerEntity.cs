using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Orion.Sirius.Domain.Entities
{
    /// <summary>
    /// Entidade Cliente
    /// </summary>
    public class CostumerEntity
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Nome/Razão Social do cliente
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Apelido/Fantasia do cliente
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// Contato
        /// </summary>
        public ContactEntity Contact { get; set; }
    }
}
