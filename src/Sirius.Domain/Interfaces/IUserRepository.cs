using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface do repositorio de usuarios
    /// </summary>
    public interface IUserRepository<UserEntity>
    {
        /// <summary>
        /// Metodo para salvar usuários
        /// </summary>
        /// <param name="user">objeto do tipo UserEntity que será salvo.</param>
        void SaveUser(UserEntity user);

        /// <summary>
        /// Logar usuário 
        /// </summary>
        /// <param name="username">nome do usuário</param>
        /// <param name="password">senha do usuário</param>
        /// <returns>retorna um objeto do tipo UserEntity caso encontre o usuário </returns>
        UserEntity Login(string username, string password);
    }
}
