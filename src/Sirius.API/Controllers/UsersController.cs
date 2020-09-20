using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sirius.API.Models;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;

namespace Sirius.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public IActionResult CreateUser([FromBody] User user)
        {
            CreateUserModel createUserModel = new CreateUserModel(user.Username, user.Password, user.TypeUser, user.TypeAccess);

            if (createUserModel.Invalid)
                return StatusCode(412, "Modelo de criação do usuário, inválido.");

            userService.CreateUser(createUserModel);
            return Created("Users", createUserModel);
        }
    }
}
