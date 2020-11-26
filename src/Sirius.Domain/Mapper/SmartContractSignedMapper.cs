using Sirius.Domain.Entities;
using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.Domain.Mapper
{
    public static class SmartContractSignedMapper
    {
        public static SmartContractSignedModel ToContractSigned(this SmartContractSignedEntity model) =>
            new SmartContractSignedModel(model.Id, model.SmartContractId, model.CompanyId, model.CustomerId
                , model.CreatedOn, model.UpdatedOn, model.Canceled);

        public static IEnumerable<SmartContractSignedModel> ToContractSigned(this IEnumerable<SmartContractSignedEntity> models) =>
            models.Select(model => model.ToContractSigned());

        public static SmartContractSignedEntity ToContractSignedEntity(this CreateSmartContractSignedModel model) =>
            new SmartContractSignedEntity()
            { 
                Id = model.Id,
                Canceled = false,
                CompanyId = model.CompanyId,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                CustomerId = model.CustomerId,
                SmartContractId = model.SmartContractId
            };

        public static SmartContractSignedEntity ToContractSignedEntity(this UpdateSmartContractSignedModel model) =>
            new SmartContractSignedEntity()
            {
                Id = model.Id,
                Canceled = model.Canceled,
                CompanyId = model.CompanyId,
                CreatedOn = model.CreatedOn,
                UpdatedOn = DateTime.Now,
                CustomerId = model.CustomerId,
                SmartContractId = model.SmartContractId
            };

    }
}
