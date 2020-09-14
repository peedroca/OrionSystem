using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Sirius.Service
{
    public class ClienteService
    {
        private readonly IClienteRepository _repository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _repository = clienteRepository;
        }

        public dynamic Insert(CreateClienteModel userModel)
        {
            if (userModel.Invalid)
                return default;

            
        }
    }
}
