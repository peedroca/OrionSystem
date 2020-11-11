using Microsoft.VisualBasic.Logging;
using Sirius.Desktop.Extesions;
using Sirius.Desktop.Models;
using Sirius.Domain.Interfaces;
using Sirius.Domain.Models;
using Sirius.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sirius.Desktop.Controllers
{
    class CostomerController
    {
        private ICustomerService customerService;

        public CostomerController()
        {
            customerService = new CustomerService(Settings.SiriusDbContext);
        }

        public IEnumerable<CostomerRequestView> GetCustomerRequests(long id, string fristName = null)
        {
            var customer = customerService.GetCustomerRequests();
            return customer?.ToCostomerView();
        }

        public IEnumerable<CostomerView> GetCustomer(long id, string fristName = null)
        {
            var customer = customerService.GetCustomers();
            return customer?.ToCostomerViews();
        }
        public void  ApproveCustomer(CustomerModel customerModel) =>
            customerService.ApproveCustomer(customerModel.Id);
        public void RequestCreateCustomer(CreateCustomerRequestModel createCustomerRequestModel) =>
            customerService.RequestCreateCustomer(createCustomerRequestModel);
        public void CostomerRefusal(CustomerRefusalModel customerRefusalModel) =>
            customerService.RefuseCustomer(customerRefusalModel.Id, customerRefusalModel.RefusalReason);






    }
}
