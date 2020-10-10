using Sirius.Domain.Models;
using System.Collections.Generic;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface do Serviço de Empresa
    /// </summary>
    public interface ICompanyService
    {
        CompanyModel CreateCompany(CreateCompanyModel createCompanyModel);
        IEnumerable<CompanyModel> GetCompanies();
        CompanyModel UpdateCompany(UpdateCompanyModel updateCompanyModel);
        CompanyModel GetCompany(long id);
    }
}
