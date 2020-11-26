using Sirius.Domain.Enums;
using Sirius.Domain.Models;
using System.Collections.Generic;

namespace Sirius.Domain.Interfaces
{
    public interface ISmartContractSignedService
    {
        SmartContractSignedModel CreateSmartContractSigned(CreateSmartContractSignedModel createSmartContract);
        IEnumerable<SmartContractSignedModel> GetSmartContractSigneds(ETypeUser typeUser, long id = 0);
        SmartContractSignedModel UpdateSmartContractSigned(UpdateSmartContractSignedModel updateSmartContract);
    }
}