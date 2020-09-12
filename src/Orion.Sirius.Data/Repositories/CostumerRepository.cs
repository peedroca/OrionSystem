using Orion.Sirius.Data.Contexts;
using Orion.Sirius.Domain.Interfaces;
using Orion.Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Orion.Sirius.Data.Repositories
{
    /// <summary>
    /// Repositório de Clientes
    /// </summary>
    public class CostumerRepository : ICostumerRepository
    {
        private SiriusDbContext context;

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="context">Contexto do banco de dados Sirius</param>
        public CostumerRepository(SiriusDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Obter Cliente
        /// </summary>
        /// <param name="pk">Chave primaria para recuperação do Cliente.</param>
        /// <returns>Retorna, caso encontre, um objeto <see cref="CostumerEntity"/> preenchido.</returns>
        public CostumerEntity GetCostumer(long pk)
        {
            return context.Costumers.Find(pk);
        }

        /// <summary>
        /// Listar clientes
        /// </summary>
        /// <returns>Retorna, caso encontre, uma lista de objetos <see cref="CostumerEntity"/>.</returns>
        public IEnumerable<CostumerEntity> GetCostumers()
        {
            return context.Costumers.ToList();
        }

        /// <summary>
        /// Salvar Cliente
        /// </summary>
        /// <param name="costumer">Objeto do tipo <see cref="CostumerEntity"/> que será salvo no banco.</param>
        public void SaveCostumer(CostumerEntity costumer)
        {
            if (costumer.Id != 0)
                context.Update(costumer);
            else
                context.Add(costumer);

            context.SaveChanges();
        }
    }
}
