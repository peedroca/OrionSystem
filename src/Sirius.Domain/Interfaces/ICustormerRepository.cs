using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface de repositorios de Clientes
    /// </summary>
    /// <typeparam name="Customer"></typeparam>
    public interface ICustomerRepository<Customer>
    {
        /// <summary>
        /// Salvar Cliente
        /// </summary>
        /// <param name="customer">Objeto do tipo Customer que será salvo.</param>
        void SaveCustomer(Customer customer);

        /// <summary>
        /// Obter cliente
        /// </summary>
        /// <param name="id"> Id do customer</param>
        /// <returns></returns>
        Customer GetCustomer(long id);

        /// <summary>
        /// Listar Clientes
        /// </summary>
        /// <returns></returns>
        IEnumerable<Customer> GetCustomer();
    }
}

