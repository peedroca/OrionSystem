using Flunt.Notifications;
using Flunt.Validations;
using Sirius.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de criação de usuário
    /// </summary>
    public class CreateUserModel : Notifiable
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="username">Nome do usuário</param>
        /// <param name="password">Senha do usuário</param>
        /// <param name="typeUser">Tipo de usuário</param>
        /// <param name="typeAccess">Tipo de acesso do usuário</param>
        public CreateUserModel(string username, string password, ETypeUser typeUser, ETypeAccess typeAccess)
        {
            Id = 0;
            Username = username;
            Password = password;
            TypeUser = typeUser;
            TypeAccess = typeAccess;
            CreatedOn = DateTime.Now;
            UpdatedOn = DateTime.Now;
            Deleted = false;
            Blocked = false;

            AddNotifications(new Contract()
                .HasMaxLen(Username, 100, "Username", "O nome do usuário deve ter no máximo 100 caracteres.")
                .HasMaxLen(Password, 50, "Password", "A senha do usuário deve ter no máximo 50 caracteres."));
        }

        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; }

        /// <summary>
        /// Nome do usuário
        /// </summary>        
        public string Username { get; }

        /// <summary>
        /// senha do usuário
        /// </summary>
        public string Password { get; }

        /// <summary>
        /// Tipo de usuário
        /// </summary>
        public ETypeUser TypeUser { get; }

        /// <summary>
        /// Tipo de acesso
        /// </summary>
        public ETypeAccess TypeAccess { get; }

        /// <summary>
        /// Data de Criação do Registro
        /// </summary>
        public DateTime CreatedOn { get; }

        /// <summary>
        /// Data de Atualização do Registro
        /// </summary>
        public DateTime UpdatedOn { get; }

        /// <summary>
        /// Registro Apagado
        /// </summary>
        public bool Deleted { get; }

        /// <summary>
        /// Bloqueado
        /// </summary>
        public bool Blocked { get; }
    }
}
