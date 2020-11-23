using Sirius.Domain.Models;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface do Serviço de usuário
    /// </summary>
    public interface IUserService
    {
        /// <summary>
        /// Logar Usuário
        /// </summary>
        /// <param name="loginUserModel"></param>
        /// <returns></returns>
        UserModel LogarUser(LoginUserModel loginUserModel);
    }
}
