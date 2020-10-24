using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirius.API.Models;
using Sirius.Domain.Interfaces;

namespace Sirius.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SmartContractsController : ControllerBase
    {
        private IMapper _mapper;
        private ISmartContractService _service;

        public SmartContractsController(IMapper mapper, ISmartContractService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        public ActionResult GetSmartContracts()
        {
            try
            {
                var contracts = _service.GetSmartContracts();

                if (contracts == null)
                    return NotFound();

                var contractsView = _mapper.Map<IEnumerable<SmartContractView>>(contracts);
                return Ok(contractsView);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}
