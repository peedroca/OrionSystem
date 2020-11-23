using Sirius.Domain.Entities;
using Sirius.Domain.Models;

namespace Sirius.Domain.Mapper
{
    /// <summary>
    /// Mapeamento do Usuário
    /// </summary>
    public static class UserMapper
    {
        /// <summary>
        /// Converter para objeto do tipo <see cref="UserModel"/>
        /// </summary>
        /// <param name="userEntity">Objeto que será convertido</param>
        /// <returns>Objeto convertido.</returns>
        public static UserModel ToUserModel(this UserEntity userEntity) =>
            new UserModel(userEntity.Id, userEntity.Username, string.Empty, userEntity.TypeUser, userEntity.TypeAccess);

        /// <summary>
        /// Converte para objeto do tipo <see cref="UserEntity"/>
        /// </summary>
        /// <param name="createUserModel">Objeto que será convertido</param>
        /// <returns>Objeto convertido.</returns>
        public static UserEntity ToUserEntity(this CreateUserModel createUserModel) =>
            new UserEntity()
            {
                Id = createUserModel.Id,
                Username = createUserModel.Username,
                Password = createUserModel.Password,
                Blocked = createUserModel.Blocked,
                CreatedOn = createUserModel.CreatedOn,
                Deleted = createUserModel.Deleted,
                TypeAccess = createUserModel.TypeAccess,
                TypeUser = createUserModel.TypeUser,
                UpdatedOn = createUserModel.UpdatedOn
            };

        /// <summary>
        /// Converte para objeto do tipo <see cref="UserEntity"/>
        /// </summary>
        /// <param name="userModel">Objeto que será convertido</param>
        /// <returns>Objeto convertido.</returns>
        public static UserEntity ToUserEntity(this UserModel userModel) =>
            new UserEntity()
            {
                Id = userModel.Id,
                Username = userModel.Username,
                Password = userModel.Password,
                TypeAccess = userModel.TypeAccess,
                TypeUser = userModel.TypeUser
            };
    }
}
