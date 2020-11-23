using Sirius.Domain.Entities;
using Sirius.Domain.Interfaces;
using Sirius.Infra.Data.Contexts;

namespace Sirius.Infra.Data.Repositories
{
    public class CustomerRefusalRepository : ICostumerRefusalRepository<CustomerRefusalEntity>
    {
        private SiriusDbContext context;

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="context">Contexto do banco de dados do tipo <see cref="SiriusDbContext"/></param>
        public CustomerRefusalRepository(SiriusDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Salva Recusa
        /// </summary>
        /// <param name="customerRf">Objeto do tipo CompanyEntity será salvo </param>
        public void SaveRefusal(CustomerRefusalEntity customerRf)
        {
            if (customerRf.Id == 0)
                context.Add(customerRf);
            else
                context.Update(customerRf);

            context.SaveChanges();
        }
    }
}
