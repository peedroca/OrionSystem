using Orion.Sirius.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Orion.Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface do Repositório de Clientes
    /// </summary>
    public interface ICostumerRepository
    {
        /// <summary>
        /// Obter Cliente
        /// </summary>
        /// <param name="pk">Chave primaria para recuperação do Cliente.</param>
        /// <returns>Retorna, caso encontre, um objeto <see cref="CostumerEntity"/> preenchido.</returns>
        CostumerEntity GetCostumer(long pk);

        /// <summary>
        /// Listar clientes
        /// </summary>
        /// <returns>Retorna, caso encontre, uma lista de objetos <see cref="CostumerEntity"/>.</returns>
        IEnumerable<CostumerEntity> GetCostumers();

        /// <summary>
        /// Salvar Cliente
        /// </summary>
        /// <param name="costumer">Objeto do tipo <see cref="CostumerEntity"/> que será salvo no banco.</param>
        void SaveCostumer(CostumerEntity costumer);
    }
}
