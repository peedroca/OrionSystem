using Sirius.Domain.Models;
using System.Collections.Generic;

namespace Sirius.Service
{
    public interface ICustomerService
    {
        bool ApproveCustomer(long IdCustomerRequest);
        IEnumerable<CustomerRequestModel> GetCustomerRequests();
        IEnumerable<CustomerModel> GetCustomers();
        bool RefuseCustomer(long IdCustomerRequest, string refusalReason);
        bool RequestCreateCustomer(CreateCustomerRequestModel model);
    }
}