using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirius.API.Models;
using Sirius.Domain.Models;
using Sirius.Service;

namespace Sirius.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CustomersController : ControllerBase
    {
        private IMapper _mapper;
        private ICustomerService _service;

        public CustomersController(IMapper mapper, ICustomerService service)
        {
            _mapper = mapper;
            _service = service;
        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult CreateCustomerRequest(CustomerRequest customerRequest)
        {
            try
            {
                var create = new CreateCustomerRequestModel(customerRequest.FirstName
                    , customerRequest.LastName
                    , customerRequest.Nickname
                    , customerRequest.CPF
                    , customerRequest.CNPJ
                    , customerRequest.Phone
                    , customerRequest.Email
                    , customerRequest.BirthDate);

                if (create.Invalid)
                    return StatusCode(412, create.Notifications);

                if (_service.RequestCreateCustomer(create))
                    return Created("Customers", create);
                else
                    return StatusCode(412, "Erro ao criar cliente");
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
        }
    }
}
