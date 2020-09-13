using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Orion.Sirius.Core.Models
{
    /// <summary>
    /// Cliente
    /// </summary>
    public class Costumer
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
        /// E-mail do cliente
        /// </summary>
        public string Email { get; set; }
    }
}
