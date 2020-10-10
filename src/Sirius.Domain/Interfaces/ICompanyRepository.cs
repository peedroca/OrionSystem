using System.Collections.Generic;

namespace Sirius.Domain.Interfaces
{
    /// <summary>
    /// Interface do repositorio da empresa
    /// </summary>
    public interface ICompanyRepository<Company>
    {
        /// <summary>
        /// Salva empresa
        /// </summary>
        /// <param name="company">Objeto do tipo CompanyEntity será salvo </param>
        void SaveCompany(Company company);

        /// <summary>
        /// Listar empresas
        /// </summary>
        /// <returns></returns>
        IEnumerable<Company> GetCompanies();

        /// <summary>
        /// Obter empresa pelo Id 
        /// </summary>
        /// <param name="id">Primary Key</param>
        /// <returns></returns>
        Company GetCompany(long id);



    }

}
