using App.Domain.Core.AppServices.Customers.Commands;
using App.Domain.Core.DataAccess;
using App.Domain.Core.DtoModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppService.Customers.Commands
{
    public class AddOrderAppService : IAddOrderAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public AddOrderAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public int Execute(AddOrderInputModel model)
        {
            // step-1 : add new order to orders
            int orderId = _customerRepository.AddOrder(model);

            // step-2 : get list of services and add to OrderService



            return orderId;
        }
    }
}
