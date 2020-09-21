using Sirius.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Entities
{
    /// <summary>
    /// Entidade Usuario
    /// </summary>
    public class UserEntity
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
        /// Bloqueado
        /// </summary>
        public bool Blocked { get; set; }
    }
}
