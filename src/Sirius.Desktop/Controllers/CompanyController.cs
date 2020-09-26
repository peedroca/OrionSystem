using Sirius.Desktop.Models;
using Sirius.Domain.Interfaces;
using Sirius.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Desktop.Controllers
{
    public class CompanyController
    {
        private ICompanyService companyService;
        
        public CompanyController()
        {
            companyService = new CompanyService(Settings.SiriusDbContext);     
        }

        public IEnumerable<CompanyView> GetCompanies()
        {
            var companies = companyService.GetCompanies();
            var resp = companies.Select(s => new CompanyView()
            {
                Name = s.Name,
                Nickname = s.Nickname,
                CNPJ = s.CNPJ,
                Phone = s.Phone,
                Email = s.Email
            }).ToList();

            return resp;
        }
    }
}
