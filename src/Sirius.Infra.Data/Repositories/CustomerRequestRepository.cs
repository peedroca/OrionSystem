using Microsoft.EntityFrameworkCore;
using Sirius.Domain.Entities;
using Sirius.Domain.Interfaces;
using Sirius.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.Infra.Data.Repositories
{
    public class CustomerRequestRepository : ICustomerRequestRepository<CustomerRequestEntity>
    {
        private SiriusDbContext context;

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="context">Contexto do banco de dados do tipo <see cref="SiriusDbContext"/></param>
        public CustomerRequestRepository(SiriusDbContext context)
        {
            this.context = context;
        }

        public void DeleteCustomerRequest(CustomerRequestEntity customerRequest)
        {
            context.RequestCustomers.Remove(customerRequest);
            context.SaveChanges();
        }

        /// <summary>
        /// Listar Clientes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerRequestEntity> GetCustomerRequests()
        {
            return context.RequestCustomers.Include(i => i.CostumerRefusal).AsNoTracking().ToList();
        }

        /// <summary>
        /// Obter clinete pelo Id 
        /// </summary>
        /// <param name="id">Primary Key</param>
        /// <returns></returns>
        public CustomerRequestEntity GetCustomerRequest(long id)
        {
            return context.RequestCustomers
                .Where(w => w.Id == id)
                .Include(i => i.CostumerRefusal)
                .AsNoTracking()
                .FirstOrDefault();
        }

        /// <summary>
        /// Salva Cliente
        /// </summary>
        /// <param name="customerRequest">Objeto do tipo CustomerRequestEntity será salvo </param>
        public void SaveCustomerRequest(CustomerRequestEntity customerRequest)
        {
            if (customerRequest.Id == 0)
                context.Add(customerRequest);
            else
                context.Update(customerRequest);

            context.SaveChanges();
        }
    }
}
