using Sirius.Domain.Models;
using System.Collections.Generic;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface do Serviço de Contrato inteligente
    /// </summary>
    public interface ISmartContractService
    {
        SmartContractModel GetSmartContract(long id);

        IEnumerable<SmartContractModel> GetSmartContracts(long idCompany);

        SmartContractModel CreateSmartContract(CreateSmartContractModel createSmartContract);

        SmartContractModel UpdateSmartContract(UpdateSmartContractModel createSmartContract);
    }
}
