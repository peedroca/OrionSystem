using Sirius.Domain.Entities;
using Sirius.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Sirius.Domain.Mapper
{
    /// <summary>
    /// Mapeamento de empresa
    /// </summary>
    public static class CompanyMapper
    {
        public static CompanyModel ToCompanyModel(this CompanyEntity companyEntity) =>
            new CompanyModel(companyEntity.Id, companyEntity.Name, companyEntity.Nickname, companyEntity.CNPJ, companyEntity.Phone, companyEntity.Email, companyEntity.SmartContracts?.ToSmartContractModel(), companyEntity.User?.ToUserModel(), companyEntity.CreatedOn, companyEntity.UpdatedOn, companyEntity.Deleted, companyEntity.Blocked);

        public static IEnumerable<CompanyModel> ToCompanyModel(this IEnumerable<CompanyEntity> companyEntities) =>
            companyEntities.Select(s => s.ToCompanyModel());

        public static CompanyEntity ToCompanyEntity(this CreateCompanyModel companyModel) =>
            new CompanyEntity()
            {
                Id = companyModel.Id,
                Blocked = companyModel.Blocked,
                CNPJ = companyModel.CNPJ,
                CreatedOn = companyModel.CreatedOn,
                Deleted = companyModel.Deleted,
                Email = companyModel.Email,
                Name = companyModel.Name,
                Phone = companyModel.Phone,
                Nickname = companyModel.Nickname,
                SmartContracts = companyModel.SmartContracts?.ToSmartContractEntity()?.ToList(),
                UpdatedOn = companyModel.UpdatedOn,
                User = companyModel.User
            };

        public static CompanyEntity ToCompanyEntity(this UpdateCompanyModel companyModel) =>
            new CompanyEntity()
            {
                Id = companyModel.Id,
                Blocked = companyModel.Blocked,
                CNPJ = companyModel.CNPJ,
                CreatedOn = companyModel.CreatedOn,
                Deleted = companyModel.Deleted,
                Email = companyModel.Email,
                Name = companyModel.Name,
                Phone = companyModel.Phone,
                Nickname = companyModel.Nickname,
                SmartContracts = companyModel.SmartContracts?.ToSmartContractEntity()?.ToList(),
                UpdatedOn = companyModel.UpdatedOn,
                User = companyModel.User?.ToUserEntity(),
            };

        public static CompanyEntity ToCompanyEntity(this CompanyModel companyModel) =>
            new CompanyEntity()
            {
                Id = companyModel.Id,
                Blocked = companyModel.Blocked,
                CNPJ = companyModel.CNPJ,
                CreatedOn = companyModel.CreatedOn,
                Deleted = companyModel.Deleted,
                Email = companyModel.Email,
                Name = companyModel.Name,
                Phone = companyModel.Phone,
                Nickname = companyModel.Nickname,
                SmartContracts = companyModel.SmartContracts?.ToSmartContractEntity()?.ToList(),
                UpdatedOn = companyModel.UpdatedOn,
                User = companyModel.User?.ToUserEntity()
            };
    }
}
