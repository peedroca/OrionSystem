using Sirius.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Desktop.Models
{
    public class UserView
    {
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public ETypeUser TypeUser { get; set; }
        public ETypeAccess TypeAccess { get; set; }
    }
}
