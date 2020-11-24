using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Desktop.Controllers
{
    class UserController
    {
        private IUserService userService;
        
        

        public UserController()
        {
            userService = new UserService(Settings.SiriusDbContext);            
        }

        public UserModel LoginUser(LoginUserModel loginUserModel) =>
            userService.LogarUser(loginUserModel);
        public void CreateUser(string fullName, string name, string email)  =>
            userService.CreateUser(fullName, name, email);

    }
}
