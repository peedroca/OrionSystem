using Sirius.CrossCutting.Email;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Mapper;
using Sirius.Domain.Models;
using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Repositories;
using System.Collections.Generic;

namespace Sirius.Service
{
    /// <summary>
    /// Serviço do Contrato Inteligente
    /// </summary>
    public class SmartContractService : ISmartContractService
    {
        private static SmartContractRepository smartContractRepository;

        /// <summary>
        /// Construtor
        /// </summary>
        public SmartContractService(SiriusDbContext siriusDbContext)
        {
            smartContractRepository = new SmartContractRepository(siriusDbContext);
        }

        public SmartContractModel CreateSmartContract(CreateSmartContractModel createSmartContract)
        {
            if (createSmartContract.Invalid)
                return default;

            var smartContractEntity = createSmartContract.ToSmartContractEntity();
            smartContractRepository.SaveSmartContract(smartContractEntity);

            if (smartContractEntity != null && Settings.SenderEmail != null)
            {
                string message = $"Novo Contrato Inteligente cadastrado para sua empresa!!\n\n{smartContractEntity.Title} Já está pronto para uso!";

                new IntegrationEmail(Settings.SenderEmail)
                    .SendEmailToUser(message, createSmartContract.CompanyModel.Email, createSmartContract.CompanyModel.Name);
            }

            return smartContractEntity.ToSmartContractModel();
        }

        public SmartContractModel GetSmartContract(long id)
        {
            var smartContract = smartContractRepository.GetContract(id);
            return smartContract?.ToSmartContractModel();
        }

        public IEnumerable<SmartContractModel> GetSmartContracts(long idCompany)
        {
            var smartContract = smartContractRepository.GetContracts(idCompany);
            return smartContract?.ToSmartContractModel();
        }

        public IEnumerable<SmartContractModel> GetSmartContracts()
        {
            var smartContract = smartContractRepository.GetContracts();
            return smartContract?.ToSmartContractModel();
        }

        public SmartContractModel UpdateSmartContract(UpdateSmartContractModel updateSmartContract)
        {
            if (updateSmartContract.Invalid)
                return default;

            var smartContractEntity = updateSmartContract.ToSmartContractEntity();
            smartContractRepository.SaveSmartContract(smartContractEntity);

            if (smartContractEntity != null && Settings.SenderEmail != null)
            {
                string message = $"Seu Contrato Inteligente: {smartContractEntity.Title} sofreu alterações!";

                new IntegrationEmail(Settings.SenderEmail)
                    .SendEmailToUser(message, updateSmartContract.CompanyModel.Email, updateSmartContract.CompanyModel.Name);
            }

            return smartContractEntity.ToSmartContractModel();
        }
    }
}
