using Sirius.CrossCutting.Email;
using Sirius.Domain.Entities;
using Sirius.Domain.Enums;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Mapper;
using Sirius.Domain.Models;
using Sirius.Infra.Data.Contexts;
using Sirius.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sirius.Service
{
    /// <summary>
    /// Serviços do Cliente
    /// </summary>
    public class CustomerService : ICustomerService
    {
        private SiriusDbContext _siriusDbContext;
        private ICustomerRepository<CustomerEntity> _customerRepository;
        private ICustomerRequestRepository<CustomerRequestEntity> _customerRequestRepository;

        public CustomerService(SiriusDbContext siriusDbContext)
        {
            _siriusDbContext = siriusDbContext;
            _customerRepository = new CustomerRepository(siriusDbContext);
            _customerRequestRepository = new CustomerRequestRepository(siriusDbContext);
        }

        public bool ApproveCustomer(long IdCustomerRequest)
        {
            bool response = false;

            try
            {
                var customerEntity = _customerRequestRepository.GetCustomerRequest(IdCustomerRequest);
                var customer = new CustomerEntity()
                {
                    Id = 0,
                    BirthDate = customerEntity.BirthDate,
                    Blocked = false,
                    CNPJ = customerEntity.CNPJ,
                    Cpf = customerEntity.CPF,
                    CreatedOn = DateTime.Now,
                    Email = customerEntity.Email,
                    FirstName = customerEntity.FirstName,
                    LastName = customerEntity.LastName,
                    Nickname = customerEntity.Nickname,
                    Phone = customerEntity.Phone,
                    UpdatedOn = DateTime.Now
                };

                var newUser = new UserService(_siriusDbContext).CreateUser(customerEntity.FirstName
                , ETypeUser.Customer
                , ETypeAccess.Comum);

                if (newUser == null)
                    return default;

                customer.User = newUser;
                _customerRepository.SaveCustomer(customer);

                if (customer != null && Settings.SenderEmail != null)
                {
                    new IntegrationEmail(Settings.SenderEmail)
                        .SendEmailToUser(newUser, customer.Email, customer.FirstName);
                }

                _customerRequestRepository.DeleteCustomerRequest(customerEntity);
                response = true;
            }
            catch (Exception)
            {
                throw;
            }

            return response;
        }

        public bool RefuseCustomer(long IdCustomerRequest, string refusalReason)
        {
            bool response = false;

            try
            {
                var customerEntity = _customerRequestRepository.GetCustomerRequest(IdCustomerRequest);
                customerEntity.CostumerRefusal = new CustomerRefusalEntity()
                {
                    Createdon = DateTime.Now,
                    Id = 0,
                    RefusalReason = refusalReason,
                    Rejected = true,
                    UpdatedOn = DateTime.Now
                };

                _customerRequestRepository.SaveCustomerRequest(customerEntity);
                response = true;
            }
            catch (Exception)
            {
                throw;
            }

            return response;
        }

        public bool RequestCreateCustomer(CreateCustomerRequestModel model)
        {
            bool response = false;

            try
            {
                if (model.Invalid)
                    return response;

                var entity = model.ToCustomerRequest();
                _customerRequestRepository.SaveCustomerRequest(entity);

                response = true;
            }
            catch (Exception)
            {
                response = false;
            }

            return response;
        }

        public IEnumerable<CustomerModel> GetCustomers()
        {
            List<CustomerModel> response = null;

            try
            {
                var customers = _customerRepository.GetCustomer();

                if (customers != null && customers?.Count() > 0)
                {
                    response = customers?.ToCustomerModel()?.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return response;
        }

        public IEnumerable<CustomerRequestModel> GetCustomerRequests()
        {
            List<CustomerRequestModel> response = null;

            try
            {
                var customers = _customerRequestRepository.GetCustomerRequests();

                if (customers != null && customers?.Count() > 0)
                {
                    response = customers?.ToCustomerRequestModel()?.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return response;
        }
    }
}
