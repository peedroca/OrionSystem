using Sirius.Domain.Entities;
using Sirius.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.Domain.Mapper
{
    /// <summary>
    /// Mapeamento de Cliente
    /// </summary>
    public static class CustomerMapper
    {
        public static CustomerModel ToCustomerModel(this CustomerEntity model)
        {
            return new CustomerModel(
                model.Id,
                model.FirstName,
                model.LastName,
                model.Nickname,
                model.Cpf,
                model.CNPJ,
                model.Phone,
                model.Email,
                model.BirthDate,
                model.CreatedOn,
                model.UpdatedOn,
                model.Blocked,
                model.User?.ToUserModel());
        }

        public static IEnumerable<CustomerModel> ToCustomerModel(this IEnumerable<CustomerEntity> model) =>
            model.Select(s => s?.ToCustomerModel());

        public static CustomerRequestModel ToCustomerRequestModel(this CustomerRequestEntity model)
        {
            return new CustomerRequestModel(model.Id
                , model.FirstName
                , model.LastName
                , model.Nickname
                , model.CPF
                , model.CNPJ
                , model.Phone
                , model.Email
                , model.BirthDate
                , model.CreatedOn
                , model.UpdatedOn
                , model.Deleted
                , model.CostumerRefusal?.ToCustomerRefusalModel());
        }

        public static IEnumerable<CustomerRequestModel> ToCustomerRequestModel(this IEnumerable<CustomerRequestEntity> model) =>
            model.Select(s => s?.ToCustomerRequestModel());

        public static CustomerRefusalModel ToCustomerRefusalModel(this CustomerRefusalEntity model)
        {
            return new CustomerRefusalModel(model.Id
                , model.RefusalReason
                , model.Createdon
                , model.UpdatedOn
                , model.Rejected);
        }

        public static CustomerRequestEntity ToCustomerRequest(this CreateCustomerRequestModel model)
        {
            return new CustomerRequestEntity()
            {
                Id = 0,
                BirthDate = model.BirthDate,
                CNPJ = model.CNPJ,
                CostumerRefusal = null,
                CPF = model.CPF,
                CreatedOn = DateTime.Now,
                UpdatedOn = DateTime.Now,
                Deleted = false,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                Nickname = model.Nickname,
                Phone = model.Phone
            };
        }
    }
}
