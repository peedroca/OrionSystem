using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirius.API.Models;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;

namespace Sirius.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SmartContractsController : ControllerBase
    {
        private IMapper _mapper;
        private ISmartContractService _service;

        public SmartContractsController(IMapper mapper
            , ISmartContractService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(statusCode: 200, Type = typeof(IEnumerable<SmartContractView>))]
        [Authorize]
        public ActionResult GetSmartContracts()
        {
            try
            {
                IEnumerable<SmartContractModel> contracts = null;

                var typeUser = (ETypeUser)Convert.ToInt32(User.FindFirst(ClaimTypes.Role)?.Value);

                switch (typeUser)
                {
                    case ETypeUser.Customer:
                        contracts = _service.GetSmartContracts();
                        break;
                    case ETypeUser.Company:
                        int companyId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
                        contracts = _service.GetSmartContracts(companyId);
                        break;
                    case ETypeUser.Employee:
                        break;
                }

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
