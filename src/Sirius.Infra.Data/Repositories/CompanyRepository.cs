using Microsoft.EntityFrameworkCore;
using Sirius.Domain.Entities;
using Sirius.Domain.Interfaces;
using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Sirius.Infra.Data.Repositories
{
    /// <summary>
    /// Repositorios da empresa
    /// </summary>
    public class CompanyRepository : ICompanyRepository<CompanyEntity>
    {
        private SiriusDbContext context;

        /// <summary>
        /// Construtor 
        /// </summary>
        /// <param name="context">Contexto do banco de dados do tipo <see cref="SiriusDbContext"/></param>
        public CompanyRepository(SiriusDbContext context)
        {
            this.context = context;
        }

        /// <summary>
        /// Listar empresas
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CompanyEntity> GetCompanies()
        {
            return context.Companies.AsNoTracking().ToList();
        }
                
        /// <summary>
        /// Obter empresa pelo Id 
        /// </summary>
        /// <param name="id">Primary Key</param>
        /// <returns></returns>
        public CompanyEntity GetCompany(long id)
        {
            return context.Companies.AsNoTracking().Where(w => w.Id == id).FirstOrDefault();
        }

        /// <summary>
        /// Salva empresa
        /// </summary>
        /// <param name="company">Objeto do tipo CompanyEntity será salvo </param>
        public void SaveCompany(CompanyEntity company)
        {
            if (company.Id == 0)
                context.Add(company);
            else
                context.Update(company);
            
            context.SaveChanges();
        }
    }
}
