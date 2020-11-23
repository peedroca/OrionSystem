using Microsoft.Identity.Client;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sirius.Domain.Models;

namespace Sirius.Desktop.Models
{
    public class CostomerRequestView
    {
        public long Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool Deleted { get; set; }
        public CustomerRefusalModel costumerRefusal { get; set; }
        public UserModel UserModel { get; set; }
    }
}
