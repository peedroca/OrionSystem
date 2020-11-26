using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sirius.API.Auth;
using Sirius.API.Models;
using Sirius.CrossCutting.Validations;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Service;
using System.Linq;

namespace Sirius.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;
        private ICustomerService _customerService;
        private ICompanyService _companyService;
        
        public LoginController(IUserService userService
            , IMapper mapper
            , ICustomerService customerService
            , ICompanyService companyService)
        {
            _userService = userService;
            _mapper = mapper;
            _customerService = customerService;
            _companyService = companyService;
        }

        /// <summary>
        /// Autenticação com a API.
        /// </summary>
        /// <param name="model">Modelo de usuário.</param>
        /// <returns>Informações do usuário e token de acesso.</returns>
        [HttpPost]
        [ProducesResponseType(statusCode: 200, Type = typeof(UserView))]
        public IActionResult Authenticate([FromBody] User model)
        {
            // Recupera o usuário
            var userModel = _userService.LogarUser(new LoginUserModel(model.Username, model.Password));

            // Verifica se o usuário existe
            if (userModel == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var user = _mapper.Map<UserView>(userModel);

            // Gera o Token
            user.AccessToken = TokenService.GenerateToken(user);

            switch (user.TypeUser)
            {
                case ETypeUser.Customer:
                    var customer = _customerService.GetCustomers().FirstOrDefault(w => w.User.Id == user.Id);
                    user.Name = customer.FirstName;
                    user.Nickname = customer.LastName;
                    user.Phone = customer.Phone;
                    user.Email = customer.Email;
                    user.Document = CpfCnpjUtils.IsValid(customer.Cpf) ? customer.Cpf : customer.CNPJ;
                    break;
                case ETypeUser.Company:
                    var company = _companyService.GetCompanies().FirstOrDefault(w => w.User.Id == user.Id);
                    user.Name = company.Name;
                    user.Nickname = company.Nickname;
                    user.Phone = company.Phone;
                    user.Email = company.Email;
                    user.Document = company.CNPJ;
                    break;
                case ETypeUser.Employee:
                    break;
            }

            return Ok(user);
        }
    }
}
