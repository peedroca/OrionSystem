using Sirius.Desktop.Models;
using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sirius.Desktop.Extesions
{
    /// <summary>
    /// Metódos de Extensão
    /// </summary>
    public static class ExtensionMethods
    {
        #region Conversão CompanyModel

        public static CompanyView ToCompanyView(this CompanyModel companyModel)
        {
            return new CompanyView()
            {
                Id = companyModel.Id,
                Name = companyModel.Name,
                Nickname = companyModel.Nickname,
                CNPJ = companyModel.CNPJ,
                Phone = companyModel.Phone,
                Email = companyModel.Email,
                Blocked = companyModel.Blocked,
                Inactive = companyModel.Deleted
            };
        }

        public static IEnumerable<CompanyView> ToCompanyView(this IEnumerable<CompanyModel> companyModels)
        {
            return companyModels.Select(s => s.ToCompanyView()).ToList();
        }

        #endregion Conversão CompanyModel

        #region
        public static SmartContractView ToSmartContractView(this SmartContractModel smartContractModel)
        {
            return new SmartContractView()
            {
                Id = smartContractModel.Id,
                title = smartContractModel.Title,
                description = smartContractModel.Description,
                terminationCondition = smartContractModel.TerminationCondition,
                conclusionCondition = smartContractModel.ConclusionCondition,
                dueDate = smartContractModel.DueDate,
                value = smartContractModel.Value,
                authKey = smartContractModel.AuthKey
            };
        }

        public static IEnumerable<SmartContractView> ToSmartContractsView(this IEnumerable<SmartContractModel> smartContractModels)
        {
            return smartContractModels.Select(s => s.ToSmartContractView()).ToList();
        }
        #endregion
    }
}
