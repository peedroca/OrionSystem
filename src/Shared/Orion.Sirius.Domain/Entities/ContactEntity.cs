using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Sirius.Domain.Entities
{
    /// <summary>
    /// Entidade Contato
    /// </summary>
    public class ContactEntity
    {
        /// <summary>
        /// Código do Contato
        /// </summary>
        public long Code { get; set; }

        /// <summary>
        /// Número de Contato
        /// </summary>
        public string Number { get; set; }
    }
}
