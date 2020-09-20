using Sirius.Domain.Models;

namespace Sirius.Domain.Interfaces
{
    public interface IUserService
    {
        void CreateUser(CreateUserModel createUserModel);
        UserModel LogarUser(LoginUserModel loginUserModel);
    }
}
