﻿using Sirius.Desktop.Extesions;
using Sirius.Desktop.Models;
using Sirius.Domain.Entities;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Migrations;
using Sirius.Infra.Data.Repositories;
using Sirius.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
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

        public IEnumerable<CompanyView> GetCompanies(string name = null, string cnpj = null)
        {
            var companies = companyService.GetCompanies().Where(w => !w.Deleted);

            if (!string.IsNullOrEmpty(name))
                companies = companies.Where(w => w.Name.ToLower().Contains(name.ToLower()));
            if (!string.IsNullOrEmpty(cnpj))
                companies = companies.Where(w => w.CNPJ.Equals(cnpj));

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
