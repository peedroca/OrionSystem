using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Desktop.Models
{
    class SmartContractView
    {
        public class SmartContractViews
        {
            public long Id { get; set; }
            public string title { get; set; }
            public string description { get; set; }
            public string terminationCondition { get; set; }
            public string conclusionCondition { get; set; }
            public DateTime dueDate { get; set; }
            public decimal value { get; set; }
            public string authKey { get; set; }

        }
    }
}
