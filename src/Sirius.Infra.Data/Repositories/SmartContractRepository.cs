using Microsoft.EntityFrameworkCore;
using Sirius.Domain.Entities;
using Sirius.Domain.Interfaces;
using Sirius.Infra.Data.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace Sirius.Infra.Data.Repositories
{
    /// <summary>
    /// Repositorio de contratos inteligentes
    /// </summary>
    public class SmartContractRepository : ISmartContractRepository<SmartContractEntity>
    {
        private SiriusDbContext context;

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="context">Contexto do banco de dados do tipo <see cref="SiriusDbContext"/></param>
        public SmartContractRepository(SiriusDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Obter contrato 
        /// </summary>
        /// <param name="id"> Id do contrato</param>
        /// <returns></returns>
        public SmartContractEntity GetContract(long id)
        {
            return context.SmartContracts.AsNoTracking()
                .Where(w => w.Id == id)
                .FirstOrDefault(); //Busca pela chave primária
        }

        /// <summary>
        /// Obter contrato por empresa
        /// </summary>
        /// <param name="id"> Id da empresa</param>
        /// <returns></returns>
        public IEnumerable<SmartContractEntity> GetContracts(long id)
        {
            return context.SmartContracts.AsNoTracking()
                .Where(w => w.CurrentCompanyEntityId == id)
                .ToList(); //Busca pela chave primária
        }

        /// <summary>
        /// Salvar Contrato Inteligente
        /// </summary>
        /// <param name="contract">Objeto do tipo SmartContract que será salvo.</param>
        public void SaveSmartContract(SmartContractEntity contract)
        {
            if (contract.Id == 0)
                context.Add(contract);
            else
                context.Update(contract);

            context.SaveChanges();

        }
    }
}
