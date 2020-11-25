using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Interfaces
{
    public interface ISmartContractSignedRepository<CustomerSnd>
    {

        /// <summary>
        /// Salvar contrato assinado
        /// </summary>
        ///<param name = "ustomerSnd> Objeto do Tipo CustomerRefusal que será salvo.</param>
        void SaveRefusal(CustomerSnd customerSnd);

        /// <summary>
        /// Listar Contratos assinados
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetSmartContractSigned();

    }
}
