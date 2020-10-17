using Sirius.Domain.Entities;
using Sirius.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Infra.Data.Repositories
{

    /// <summary>
    /// Repositorio de Clientes
    /// </summary>

    public class CustomerRepository : ICustomerRepository<CustomerEntity>
    {
        public CustomerEntity GetCustomer(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerEntity> GetCustomer()
        {
            throw new NotImplementedException();
        }

        public void SaveCustomer(CustomerEntity customer)
        {
            throw new NotImplementedException();
        }
    }
}
