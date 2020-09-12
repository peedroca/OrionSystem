using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Sirius.Shared.Models
{
    /// <summary>
    /// Entidade Contato
    /// </summary>
    public class Contact
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
