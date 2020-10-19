using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Desktop.Models
{
    public class SmartContractViews
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TerminationCondition { get; set; }
        public string ConclusionCondition { get; set; }
        public decimal Value { get; set; }
        public CompanyModel CompanyModel { get; set; } 
    }
}
