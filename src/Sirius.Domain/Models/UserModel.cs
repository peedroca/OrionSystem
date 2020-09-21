using Sirius.Domain.Enums;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de Usuário
    /// </summary>
    public class UserModel
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="id">Identificação do usuário</param>
        /// <param name="username">Nome do usuário</param>
        /// <param name="password">Senha do usuário</param>
        /// <param name="typeUser">Tipo de usuário</param>
        /// <param name="typeAccess">Acesso do usuário</param>
        public UserModel(long id, string username, string password, ETypeUser typeUser, ETypeAccess typeAccess)
        {
            Id = id;
            Username = username;
            Password = password;
            TypeUser = typeUser;
            TypeAccess = typeAccess;
        }

        /// <summary>
        /// Identificação
        /// </summary>
        public long Id { get; set; }

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
    }
}
