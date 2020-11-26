using Sirius.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Mobile.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

    }

    public class UserLogged
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
        /// Razão Social / Nome
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Fantasia / Apelido
        /// </summary>
        public string Nickname { get; set; }

        /// <summary>
        /// CPF / CNPJ
        /// </summary>
        public string Document { get; set; }

        /// <summary>
        /// Telefone
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Tipo de usuário
        /// </summary>
        public ETypeUser TypeUser { get; set; }

        /// <summary>
        /// Tipo de acesso
        /// </summary>
        public ETypeAccess TypeAccess { get; set; }

        /// <summary>
        /// Token de Acesso
        /// </summary>
        public string AccessToken { get; set; }
    }

}
