using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface do Serviço de Empresa
    /// </summary>
    public interface ICompanyService
    {
        CompanyModel CreateCompany(CreateCompanyModel createCompanyModel);
        IEnumerable<CompanyModel> GetCompanies();
    }
}
