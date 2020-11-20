using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface de Requisição de Clientes
    /// </summary>
    public interface ICustomerRequestRepository<T> where T : class
    {
        /// <summary>
        /// Salvar Requisição Cliente
        /// </summary>
        /// <param name="customerR">Objeto do tipo CustomerRequest que será salvo.</param>
        void SaveCustomerRequest(T customerR);

        /// <summary>
        /// Deletar Requisição de Cliente
        /// </summary>
        /// <param name="T"></param>
        void DeleteCustomerRequest(T customerR);

        /// <summary>
        /// Obter Requisição de cliente
        /// </summary>
        /// <param name="id"> Id do customer Request</param>
        /// <returns></returns>
        T GetCustomerRequest(long id);

        /// <summary>
        /// Listar REquisição de Clientes
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetCustomerRequests();
    }
}
