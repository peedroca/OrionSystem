using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Desktop.Models
{
    public class CostomerView
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
        public bool Blocked { get; set; }       
        public UserModel UserModel { get; set; }
    }
}
