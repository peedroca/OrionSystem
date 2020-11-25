using Sirius.Domain.Interfaces;
using Sirius.Infra.Data.Contexts;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Sirius.Infra.Data.Repositories
{
    public class SmartContractSignedRespository : ISmartContractSignedRepository<SmartContractSignedEntity>
    {
        private SiriusDbContext context;

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="context">Contexto do banco de dados do tipo <see cref="SiriusDbContext"/></param>
        public SmartContractSignedRespository(SiriusDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<SmartContractSignedEntity> GetSmartContractSigned()
        {
            return context.SmartContractSigneds.AsNoTracking().ToList();
        }

        public void SaveSign(SmartContractSignedEntity customerSnd)
        {
            if (customerSnd.Id == 0)
                context.Add(customerSnd);
            else
                context.Update(customerSnd);

            context.SaveChanges();
        }
    }
}
