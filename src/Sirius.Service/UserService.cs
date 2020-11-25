using Flunt.Notifications;
using Sirius.CrossCutting.Email;
using Sirius.Domain.Entities;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Mapper;
using Sirius.Domain.Models;
using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Repositories;
using System;

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
            return userEntity?.ToUserModel();
        }

        public void CreateUser(string fullName, string name, string email)
        {
            try
            {
                var newUser = CreateUser(name, ETypeUser.Employee, ETypeAccess.Comum);

                if (Settings.SenderEmail != null)
                {
                    new IntegrationEmail(Settings.SenderEmail)
                        .SendEmailToUser(newUser, email, fullName);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal UserEntity CreateUser(string name, ETypeUser typeUser, ETypeAccess typeAccess)
        {
            string username = GenerateUsername(name);

            var userForCompany = new CreateUserModel(username
                , new Random().Next(11111, 99999).ToString()
                , typeUser
                , typeAccess);

            if (userForCompany.Invalid)
                return default;

            return CreateUser(userForCompany);
        }

        #region Private Methods

        private UserEntity CreateUser(CreateUserModel createUserModel)
        {
            if (createUserModel.Invalid)
                return default;

            var user = createUserModel.ToUserEntity();
            userRepository.SaveUser(user);

            return user;
        }

        private string GenerateUsername(string name)
        {
            string newName = name.ToLower().Replace(" ", "")
                .Replace("a", "4")
                .Replace("e", "3")
                .Replace("i", "1")
                .Replace("o", "0");

            newName = $"{newName}sirius".Substring(0, 4);
            newName += $"@{new Random().Next(111, 999)}";

            return newName.Trim();
        }

        #endregion Private Methods
    }
}
