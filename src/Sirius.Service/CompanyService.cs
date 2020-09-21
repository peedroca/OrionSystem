using Sirius.Domain.Entities;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Mapper;
using Sirius.Domain.Models;
using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Repositories;
using System;
using System.Collections.Generic;

namespace Sirius.Service
{
    /// <summary>
    /// Serviço da Empresa
    /// </summary>
    public class CompanyService : ICompanyService
    {
        private static CompanyRepository companyRepository;
        private SiriusDbContext siriusDbContext;

        /// <summary>
        /// Construtor
        /// </summary>
        public CompanyService(SiriusDbContext siriusDbContext)
        {
            this.siriusDbContext = siriusDbContext;
            companyRepository = new CompanyRepository(siriusDbContext);
        }

        public CompanyModel CreateCompany(CreateCompanyModel createCompanyModel)
        {
            if (createCompanyModel.Invalid)
                return default;

            var newUser = new UserService(siriusDbContext).CreateUser(createCompanyModel.Name
                , ETypeUser.Company
                , ETypeAccess.Comum);

            if (newUser == null)
                return default;

            createCompanyModel.ChangeUser(newUser);

            var companyEntity = createCompanyModel.ToCompanyEntity();
            companyRepository.SaveCompany(companyEntity);

            return companyEntity.ToCompanyModel();
        }

        public CompanyModel UpdateCompany(UpdateCompanyModel updateCompanyModel)
        {
            if (updateCompanyModel.Invalid)
                return default;

            var company = GetCompany(updateCompanyModel.Id);
            
            if (company == null)
                return default;

            updateCompanyModel.LoadCreationDate(company.CreatedOn);
            updateCompanyModel.LoadSmartContracts(company.SmartContracts);
            updateCompanyModel.LoadUser(company.User);

            var companyEntity = updateCompanyModel.ToCompanyEntity();
            companyRepository.SaveCompany(companyEntity);

            return companyEntity?.ToCompanyModel();
        }

        public IEnumerable<CompanyModel> GetCompanies()
        {
            var companies = companyRepository.GetCompanies();
            return companies?.ToCompanyModel();
        }

        public CompanyModel GetCompany(long id)
        {
            var company = companyRepository.GetCompany(id);
            return company?.ToCompanyModel();
        }
    }
}
