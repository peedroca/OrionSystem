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

    /// <summary>
    /// Repositorio de Clientes
    /// </summary>

    public class CustomerRepository : ICustomerRepository<CustomerEntity>
    {
        private SiriusDbContext context;

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="context">Contexto do banco de dados do tipo <see cref="SiriusDbContext"/></param>
        public CustomerRepository(SiriusDbContext context)
        {
            this.context = context;
        }

        public void DeleteCustomer(CustomerEntity customer)
        {
            context.Customers.Remove(customer);

            context.SaveChanges();
        }
        /// <summary>
        /// Listar Clientes
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerEntity> GetCustomer()
        {
            return context.Customers.AsNoTracking().ToList();
        }

        /// <summary>
        /// Obter clinete pelo Id 
        /// </summary>
        /// <param name="id">Primary Key</param>
        /// <returns></returns>
        public CustomerEntity GetCustomer(long id)
        {
            return context.Customers
                .Where(w => w.Id == id)
                .AsNoTracking()
                .FirstOrDefault();
        }


        /// <summary>
        /// Salva Cliente
        /// </summary>
        /// <param name="customer">Objeto do tipo CustomerEntity será salvo </param>

        public void SaveCustomer(CustomerEntity customer)
        {
            if (customer.Id == 0)
                context.Add(customer);
            else
                context.Update(customer);

            context.SaveChanges();
        }


    }
}
