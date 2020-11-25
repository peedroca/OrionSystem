using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Interfaces
{
    public interface ISmartContractSignedRepository<SmartContractSignedEntity>
    {

        /// <summary>
        /// Salvar contrato assinado
        /// </summary>
        ///<param name = "ustomerSnd> Objeto do Tipo CustomerRefusal que será salvo.</param>
        void SaveSign(SmartContractSignedEntity customerSnd);

        /// <summary>
        /// Listar Contratos assinados
        /// </summary>
        /// <returns></returns>
        IEnumerable<SmartContractSignedEntity> GetSmartContractSigned();

    }
}
