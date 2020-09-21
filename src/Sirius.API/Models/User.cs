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
        /// Senha do usuário
        /// </summary>
        public string Password { get; set; }
    }
}
