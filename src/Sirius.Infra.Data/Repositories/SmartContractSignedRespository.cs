using Sirius.Domain.Interfaces;
using Sirius.Infra.Data.Contexts;
using Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Infra.Data.Repositories
{
    public class SmartContractSignedRespository : SmartContractSignedEntity
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
       

        /// <summary>
        /// Salva 
        /// </summary>
        /// <param name="customerSnd">Objeto do tipo SmartContractSigned será salvo </param>
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
