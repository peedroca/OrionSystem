using Sirius.Desktop.Models;
using Sirius.Domain.Models;
using System.Collections.Generic;
using System.Linq;

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

        #region Conversão SmartContractModel
        public static SmartContractViews ToSmartContractView(this SmartContractModel smartContractModel)
        {
            return new SmartContractViews()
            {
                Id = smartContractModel.Id,
                Title = smartContractModel.Title,
                Description = smartContractModel.Description,
                TerminationCondition = smartContractModel.TerminationCondition,
                ConclusionCondition = smartContractModel.ConclusionCondition,
                Value = smartContractModel.Value,
                CompanyModel = smartContractModel.CompanyModel
            };
        }

        public static IEnumerable<SmartContractViews> ToSmartContractView(this IEnumerable<SmartContractModel> smartContractModels)
        {
            return smartContractModels.Select(s => s.ToSmartContractView()).ToList();
        }
        #endregion Conversão SmartContractModel

        #region Conversão CostomerRequestModel
        public static CostomerRequestView ToCostomerView(this CustomerRequestModel costomerModel)
        {
            return new CostomerRequestView()
            {
                Id = costomerModel.Id,
                FristName = costomerModel.FirstName,
                LastName = costomerModel.LastName,
                Nickname = costomerModel.Nickname,
                CPF = costomerModel.CPF,
                CNPJ = costomerModel.CNPJ,
                Phone = costomerModel.Phone,
                Email = costomerModel.Email,
                BirthDate = costomerModel.BirthDate,
                CreateOn = costomerModel.CreatedOn,
                UpdatedOn = costomerModel.UpdatedOn,
                Deleted = costomerModel.Deleted,
                costumerRefusal = costomerModel.CostumerRefusal
            };         
        }
        public static IEnumerable<CostomerRequestView> ToCostomerView(this IEnumerable<CustomerRequestModel> costomerRequestModels)
        {
            return costomerRequestModels.Select(s => s.ToCostomerView()).ToList();
        }
        #endregion Conversão CostomerRequestModel

        #region Conversão CostomerModel

        public static CostomerView ToCostomerViews (this CustomerModel customerModels)
        {
            return new CostomerView()
            {
                Id = customerModels.Id,
                FristName = customerModels.FirstName,
                LastName = customerModels.LastName,
                Nickname = customerModels.Nickname,
                CPF = customerModels.Cpf,
                CNPJ = customerModels.CNPJ,
                Phone = customerModels.Phone,
                Email = customerModels.Email,
                BirthDate = customerModels.BirthDate,
                CreateOn = customerModels.CreatedOn,
                UpdatedOn = customerModels.UpdatedOn,
                Blocked = customerModels.Blocked,
                UserModel = customerModels.User
            };
        }
        public static IEnumerable<CostomerView> ToCostomerViews(this IEnumerable<CustomerModel> customerModel)
        {
            return customerModel.Select(s => s.ToCostomerViews()).ToList();
        }
        #endregion Conversão CostomerModel

        #region Conversão UserModel

        public static UserView ToUserView(this UserModel userModel)
        {
            return new UserView()
            {
                Id = userModel.Id,
                Username = userModel.Username,
                Password = userModel.Password,
                TypeUser = userModel.TypeUser,
                TypeAccess = userModel.TypeAccess
            };
        }
        
        public static IEnumerable<UserView> ToUserViews(this IEnumerable<UserModel> userModels)
        {
            return userModels.Select(s => s.ToUserView()).ToList();
        }
        #endregion Conversão UserModel
    }
}
