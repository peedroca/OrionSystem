using Sirius.Desktop.Extesions;
using Sirius.Desktop.Models;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            var companies = companyService.GetCompanies().Where(w => !w.Deleted);
            return companies.ToCompanyView();
        }

        public void CreateCompany(CreateCompanyModel createCompanyModel) =>
            companyService.CreateCompany(createCompanyModel);

        public CompanyView GetCompanyView(long id) =>
            companyService.GetCompany(id).ToCompanyView();

        public void UpdateCompany(UpdateCompanyModel updateCompanyModel) =>
            companyService.UpdateCompany(updateCompanyModel);
    }
}
