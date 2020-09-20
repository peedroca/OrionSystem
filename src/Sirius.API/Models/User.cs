using Sirius.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sirius.API.Models
{
    public class User
    {
        /// <summary>
        /// Nome do usuário
        /// </summary>        
        public string Username { get; set; }

        /// <summary>
        /// senha do usuário
        /// </summary>
        public string Password { get; set; }

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
