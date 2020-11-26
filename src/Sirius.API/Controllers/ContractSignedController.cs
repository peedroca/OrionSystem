using AutoMapper;
using Flunt.Notifications;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirius.API.Models;
using Sirius.CrossCutting.Validations;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Service;
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
        private ICompanyService _companyService;
        private ICustomerService _customerService;

        public ContractSignedController(IMapper mapper
            , ISmartContractSignedService service
            , ISmartContractService contractService
            , ICompanyService companyService
            , ICustomerService customerService)
        {
            _mapper = mapper;
            _service = service;
            _contractService = contractService;
            _companyService = companyService;
            _customerService = customerService;
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

        [HttpDelete("{id}")]
        [ProducesResponseType(statusCode: 201, Type = typeof(SmartContractSignedModel))]
        [ProducesResponseType(statusCode: 412, Type = typeof(ICollection<Notification>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(string))]
        [Authorize]
        public IActionResult UpdateSigned(long id)
        {
            try
            {
                var contractSigned = _service.GetSmartContractSigneds(id);

                if (contractSigned == null)
                    return NotFound();

                var model = new UpdateSmartContractSignedModel(id, contractSigned.SmartContractId
                    , contractSigned.CompanyId
                    , contractSigned.CustomerId
                    , contractSigned.CreatedOn
                    , true);

                if (model.Invalid)
                    return StatusCode(412, model.Notifications);

                return StatusCode(200, _service.UpdateSmartContractSigned(model));
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [ProducesResponseType(statusCode: 200, Type = typeof(List<ContractSignedView>))]
        [ProducesResponseType(statusCode: 500, Type = typeof(string))]
        [Authorize]
        public IActionResult Get()
        {
            try
            {
                List<ContractSignedView> resp = new List<ContractSignedView>();

                var typeUser = (ETypeUser)Convert.ToInt32(User.FindFirst(ClaimTypes.Role)?.Value);
                int companyId = Convert.ToInt32(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);

                var contracts = _service.GetSmartContractSigneds(typeUser, companyId);

                if (contracts == null || contracts.Count() <= 0)
                    return NotFound();

                foreach (var item in contracts)
                {
                    var signed = new ContractSignedView();
                    signed.Id = item.Id;

                    var contract = _contractService.GetSmartContract(item.SmartContractId);
                    signed.IdContract = contract.Id;
                    signed.Title = contract.Title;
                    signed.Description = contract.Description;
                    signed.TerminationCondition = contract.TerminationCondition;
                    signed.ConclusionCondition = contract.ConclusionCondition;
                    signed.Value = contract.Value;

                    var company = _companyService.GetCompany(item.CompanyId);
                    signed.DocumentCompany = company.CNPJ;
                    signed.EmailCompany = company.Email;
                    signed.IdCompany = company.Id;
                    signed.NameCompany = company.Name;
                    signed.NicknameCompany = company.Nickname;
                    signed.PhoneCompany = company.Phone;

                    var customer = _customerService.GetCustomers().First(w => w.Id == item.CustomerId);
                    signed.DocumentCustomer = CpfCnpjUtils.IsValid(customer.Cpf) ? customer.Cpf : customer.CNPJ;
                    signed.EmailCustomer = customer.Email;
                    signed.IdCustomer = customer.Id;
                    signed.NameCustomer = customer.FirstName + customer.LastName;
                    signed.NicknameCustomer = customer.Nickname;
                    signed.PhoneCustomer = customer.Phone;

                    resp.Add(signed);
                }

                return Ok(resp);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
