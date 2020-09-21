using Flunt.Notifications;

namespace Sirius.Domain.Models
{
    /// <summary>
    /// Modelo de Login de Usuário
    /// </summary>
    public class LoginUserModel : Notifiable
    {
        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="username">Nome do usuário</param>
        /// <param name="password">Senha do usuário</param>
        public LoginUserModel(string username, string password)
        {
            Username = username;
            Password = password;
        }

        /// <summary>
        /// Nome do usuário
        /// </summary>        
        public string Username { get; }

        /// <summary>
        /// senha do usuário
        /// </summary>
        public string Password { get; }
    }
}
