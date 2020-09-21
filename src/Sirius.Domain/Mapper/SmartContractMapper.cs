using Sirius.Domain.Entities;
using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.Domain.Mapper
{
    /// <summary>
    /// Mapeamento do contrato inteligente
    /// </summary>
    public static class SmartContractMapper
    {
        public static SmartContractModel ToSmartContractModel(this SmartContractEntity smartContractEntity) =>
            new SmartContractModel(smartContractEntity.Id, smartContractEntity.Title, smartContractEntity.Description, smartContractEntity.TerminationCondition, smartContractEntity.ConclusionCondition, smartContractEntity.DueDate, smartContractEntity.Value, smartContractEntity.AuthKey, smartContractEntity.CompanyEntity?.ToCompanyModel());

        public static IEnumerable<SmartContractModel> ToSmartContractModel(this IEnumerable<SmartContractEntity> smartContractEntities) =>
            smartContractEntities.Select(s => s.ToSmartContractModel());

        public static SmartContractEntity ToSmartContractEntity(this SmartContractModel smartContractModel) =>
            new SmartContractEntity()
            {
                Id = smartContractModel.Id,
                AuthKey = smartContractModel.AuthKey,
                CompanyEntity = smartContractModel.CompanyModel?.ToCompanyEntity(),
                ConclusionCondition = smartContractModel.ConclusionCondition,
                Description = smartContractModel.Description,
                DueDate = smartContractModel.DueDate,
                TerminationCondition = smartContractModel.TerminationCondition,
                Title = smartContractModel.Title,
                Value = smartContractModel.Value
            };

        public static IEnumerable<SmartContractEntity> ToSmartContractEntity(this IEnumerable<SmartContractModel> smartContractModels) =>
            smartContractModels.Select(s => s.ToSmartContractEntity());
    }
}
