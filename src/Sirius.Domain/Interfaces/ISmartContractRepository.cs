using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface de repositorios de Contratos Inteligentes
    /// </summary>
    /// <typeparam name="SmartContract"></typeparam>
    public interface ISmartContractRepository<SmartContract>
    {
        /// <summary>
        /// Salvar Contrato Inteligente
        /// </summary>
        /// <param name="contract">Objeto do tipo SmartContract que será salvo.</param>
        void SaveSmartContract(SmartContract contract);

        /// <summary>
        /// Obter contrato 
        /// </summary>
        /// <param name="id"> Id do contrato</param>
        /// <returns></returns>
        SmartContract GetContract(long id);
    }
}
