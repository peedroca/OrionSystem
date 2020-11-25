using AutoMapper;
using Flunt.Notifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirius.API.Models;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Sirius.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractSignedController : ControllerBase
    {
        private IMapper _mapper;
        private ISmartContractSignedService _service;
        private ISmartContractService _contractService;

        public ContractSignedController(IMapper mapper
            , ISmartContractSignedService service
            , ISmartContractService contractService)
        {
            _mapper = mapper;
            _service = service;
            _contractService = contractService;
        }

        [HttpPost]
        [ProducesResponseType(statusCode: 201, Type = typeof(SmartContractSignedModel))]
        [ProducesResponseType(statusCode: 412, Type = typeof(ICollection<Notification>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(string))]
        [Authorize]
        public IActionResult CreateSigned([FromBody] CreateContractSigned contractSigned)
        {
            try
            {
                var model = new CreateSmartContractSignedModel(contractSigned.SmartContractId
                    , contractSigned.CompanyId
                    , contractSigned.CustomerId);

                if (model.Invalid)
                    return StatusCode(412, model.Notifications);

                return StatusCode(201, _service.CreateSmartContractSigned(model));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Authorize]
        public ActionResult<dynamic> Get()
        {
            try
            {
                var typeUser = (ETypeUser)Convert.ToInt32(User.FindFirst(ClaimTypes.Role)?.Value);
                int companyId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                var contracts = _service.GetSmartContractSigneds(typeUser, companyId);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
