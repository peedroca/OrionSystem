using Newtonsoft.Json;
using Orion.Sirius.Shared.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Orion.Sirius.Shared.Services
{
    /// <summary>
    /// Serviço de Cliente
    /// </summary>
    public static class CostumerService
    {
        /// <summary>
        /// Listar Clientes
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Costumer> GetCostumers()
        {
            try
            {
                var service = new RestService<Costumer>(SharedSettings.EndPoint);
                return service.List("costumers");
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Cadastrar Cliente
        /// </summary>
        /// <returns>Retorna cliente cadastrado</returns>
        public static Costumer SaveCostumer(Costumer costumer)
        {
            try
            {
                if (!EmailIsValid(costumer.Email))
                    throw new ArgumentException("Email inválido.");

                var service = new RestService<Costumer>(SharedSettings.EndPoint);
                return service.Post("costumers", costumer);
            }
            catch (Exception)
            {
                throw;
            }
        }
       
        private static bool EmailIsValid(string email)
        {
            return true;
        }
    }
}
