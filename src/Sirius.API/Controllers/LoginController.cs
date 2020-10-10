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
        private IUserService userService;

        public LoginController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public ActionResult<dynamic> Authenticate([FromBody] User model)
        {
            // Recupera o usuário
            var user = userService.LogarUser(new LoginUserModel(model.Username, model.Password));

            // Verifica se o usuário existe
            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

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
