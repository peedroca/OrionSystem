using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Sirius.API.Auth;
using Sirius.API.Models;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;

namespace Sirius.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;

        public LoginController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        /// <summary>
        /// Autenticação com a API.
        /// </summary>
        /// <param name="model">Modelo de usuário.</param>
        /// <returns>Informações do usuário e token de acesso.</returns>
        [HttpPost]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            // Recupera o usuário
            var userModel = _userService.LogarUser(new LoginUserModel(model.Username, model.Password));

            // Verifica se o usuário existe
            if (userModel == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var user = _mapper.Map<UserView>(userModel);

            // Gera o Token
            var token = TokenService.GenerateToken(user);

            // Retorna os dados
            return new
            {
                user,
                token
            };
        }
    }
}
