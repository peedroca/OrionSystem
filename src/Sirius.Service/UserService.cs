using Flunt.Notifications;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Mapper;
using Sirius.Domain.Models;
using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Repositories;

namespace Sirius.Service
{
    /// <summary>
    /// Serviços do usuário
    /// </summary>
    public class UserService : Notifiable, IUserService
    {
        private static UserRepository userRepository;

        /// <summary>
        /// Construtor
        /// </summary>
        public UserService(SiriusDbContext siriusDbContext)
        {
            userRepository = new UserRepository(siriusDbContext);
        }

        public UserModel LogarUser(LoginUserModel loginUserModel)
        {
            if (loginUserModel.Invalid)
                return default;

            var userEntity = userRepository.Login(loginUserModel.Username, loginUserModel.Password);
            return userEntity.ToUserModel();
        }

        public void CreateUser(CreateUserModel createUserModel)
        {
            if (createUserModel.Invalid)
                return;

            userRepository.SaveUser(createUserModel.ToUserEntity());
        }
    }
}
