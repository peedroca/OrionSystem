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

        public void CreateUser(LoginUserModel loginUserModel) =>
            userService.LogarUser(loginUserModel);
        
    }
}
