using Sirius.CrossCutting.Email;
using Sirius.Domain.Entities;
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
        private static CompanyRepository companyRepository;

        /// <summary>
        /// Construtor
        /// </summary>
        public SmartContractService(SiriusDbContext siriusDbContext)
        {
            smartContractRepository = new SmartContractRepository(siriusDbContext);
            companyRepository = new CompanyRepository(siriusDbContext);
        }

        public SmartContractModel CreateSmartContract(CreateSmartContractModel createSmartContract)
        {
            try
            {
                if (createSmartContract.Invalid)
                    return default;

                var company = companyRepository.GetCompany(createSmartContract.CompanyModel.Id);
                
                if (company.SmartContracts == null)
                    company.SmartContracts = new List<SmartContractEntity>();

                var smartContractEntity = createSmartContract.ToSmartContractEntity();
                company.SmartContracts.Add(smartContractEntity);

                companyRepository.SaveCompany(company);

                if (smartContractEntity != null && Settings.SenderEmail != null)
                {
                    string message = $"Novo Contrato Inteligente cadastrado para sua empresa!!\n\n{smartContractEntity.Title} Já está pronto para uso!";

                    new IntegrationEmail(Settings.SenderEmail)
                        .SendEmailToUser(message, createSmartContract.CompanyModel.Email, createSmartContract.CompanyModel.Name);
                }

                return smartContractEntity.ToSmartContractModel();
            }
            catch (System.Exception e)
            {

                throw e; 
            }
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
