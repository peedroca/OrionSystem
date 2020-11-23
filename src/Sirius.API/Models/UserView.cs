using Sirius.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sirius.API.Models
{
    /// <summary>
    /// Visualização do usuário
    /// </summary>
    public class UserView
    {
        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Nome do usuário
        /// </summary>        
        public string Username { get; set; }

        /// <summary>
        /// Tipo de usuário
        /// </summary>
        public ETypeUser TypeUser { get; set; }

        /// <summary>
        /// Tipo de acesso
        /// </summary>
        public ETypeAccess TypeAccess { get; set; }
    }
}
