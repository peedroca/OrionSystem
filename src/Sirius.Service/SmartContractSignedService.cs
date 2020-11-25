using Sirius.Domain.Entities;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Mapper;
using Sirius.Domain.Models;
using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.Service
{
    public class SmartContractSignedService : ISmartContractSignedService
    {
        private static SmartContractSignedRespository smartContractSignedRepository;

        /// <summary>
        /// Construtor
        /// </summary>
        public SmartContractSignedService(SiriusDbContext siriusDbContext)
        {
            smartContractSignedRepository = new SmartContractSignedRespository(siriusDbContext);
        }

        public SmartContractSignedModel CreateSmartContractSigned(CreateSmartContractSignedModel createSmartContract)
        {
            try
            {
                if (createSmartContract.Invalid)
                    return default;

                if (smartContractSignedRepository.GetSmartContractSigned().Count(w => w.Canceled == false
                     && w.CompanyId == createSmartContract.CompanyId
                     && w.CustomerId == createSmartContract.CustomerId
                     && w.SmartContractId == createSmartContract.SmartContractId) > 0)
                    throw new ArgumentException("O Contrato já está assinado e ativo.");

                var entity = createSmartContract.ToContractSignedEntity();
                smartContractSignedRepository.SaveSign(entity);

                return entity.ToContractSigned();
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }

        public SmartContractSignedModel UpdateSmartContractSigned(UpdateSmartContractSignedModel updateSmartContract)
        {
            try
            {
                if (updateSmartContract.Invalid)
                    return default;

                var smartCotracts = smartContractSignedRepository.GetSmartContractSigned().FirstOrDefault(f => f.Id == updateSmartContract.Id);
                smartCotracts.CreatedOn = updateSmartContract.CreatedOn;
                smartCotracts.Canceled = updateSmartContract.Canceled;

                smartContractSignedRepository.SaveSign(smartCotracts);

                return smartCotracts.ToContractSigned();
            }
            catch (System.Exception e)
            {

                throw e;
            }
        }

        public IEnumerable<SmartContractSignedModel> GetSmartContractSigneds(ETypeUser typeUser, long id = 0)
        {
            IEnumerable<SmartContractSignedEntity> contracts = null;

            switch (typeUser)
            {
                case ETypeUser.Customer:
                    contracts = smartContractSignedRepository.GetSmartContractSigned().Where(w => w.CustomerId == id);
                    break;
                case ETypeUser.Company:
                    contracts = smartContractSignedRepository.GetSmartContractSigned().Where(w => w.CompanyId == id);
                    break;
                case ETypeUser.Employee:
                    contracts = smartContractSignedRepository.GetSmartContractSigned();
                    break;
            }

            return contracts?.ToContractSigned();
        }
    }
}
