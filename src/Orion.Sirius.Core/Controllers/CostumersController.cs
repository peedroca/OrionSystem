using Microsoft.AspNetCore.Mvc;
using Orion.Sirius.Domain.Interfaces;
using AutoMapper;
using Orion.Sirius.Core.Models;
using System.Collections.Generic;
using Orion.Sirius.Domain.Entities;
using System;

namespace Orion.Sirius.Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumersController : ControllerBase
    {
        private ICostumerRepository costumerRepository;
        private IMapper mapper;

        public CostumersController(ICostumerRepository costumerRepository, IMapper mapper)
        {
            this.costumerRepository = costumerRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult List()
        {
            var costumers = costumerRepository.GetCostumers();
            return Ok(mapper.Map<IEnumerable<Costumer>>(costumers));
        }

        [HttpPost]
        public IActionResult SaveCostumer([FromBody] Costumer costumer)
        {
            try
            {
                if (string.IsNullOrEmpty(costumer.Name))
                    throw new ArgumentException("O nome é obrigatório!");

                var costumerEntity = mapper.Map<CostumerEntity>(costumer);
                costumerRepository.SaveCostumer(costumerEntity);

                return Created("api/costumers", costumerEntity);
            }
            catch (ArgumentException e)
            {
                return StatusCode(412, e.Message);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
