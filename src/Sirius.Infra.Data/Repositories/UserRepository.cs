using Microsoft.EntityFrameworkCore;
using Sirius.Domain.Entities;
using Sirius.Domain.Interfaces;
using Sirius.Infra.Data.Contexts;
using System.Linq;

namespace Sirius.Infra.Data.Repositories
{
    /// <summary>
    /// Repositorio de Usuários
    /// </summary>
    public class UserRepository : IUserRepository<UserEntity>
    {
        private SiriusDbContext context;

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="context">Contexto do banco de dados </param>
        public UserRepository(SiriusDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Logar usuário 
        /// </summary>
        /// <param name="username">nome do usuário</param>
        /// <param name="password">senha do usuário</param>
        /// <returns>retorna um objeto do tipo UserEntity caso encontre o usuário </returns>
        public UserEntity Login(string username, string password)
        {
            return context.Users
                .AsNoTracking()
                .Where(w => w.Username == username && w.Password == password)
                .SingleOrDefault(); // Método p Verificar se há usuáros com o mesmo nome
        }

        /// <summary>
        /// Metodo para salvar usuários
        /// </summary>
        /// <param name="user">objeto do tipo UserEntity que será salvo.</param>
        public void SaveUser(UserEntity user)
        {
            if (user.Id == 0)
                context.Add(user);
            else
                context.Update(user);

            context.SaveChanges();
        }
    }
}
