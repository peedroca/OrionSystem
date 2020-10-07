using System.Collections.Generic;

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

        /// <summary>
        /// Obter Contratos
        /// </summary>
        /// <param name="id">Id da empresa</param>
        /// <returns></returns>
        IEnumerable<SmartContract> GetContracts(long id);
    }
}
