using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface de recusa de Clientes
    /// </summary>
    public interface ICostumerRefusalRepository<CustomerRf>
    {
        /// <summary>
        /// Salvar Recusa de Cliente
        /// </summary>
        ///<param name = "customerRf> Objeto do Tipo CustomerRefusal que será salvo.</param>
        void SaveRefusal(CustomerRf customerRf);
    }
}

