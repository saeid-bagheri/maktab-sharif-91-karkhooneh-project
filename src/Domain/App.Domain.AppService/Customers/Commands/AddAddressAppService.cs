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
    public class AddAddressAppService : IAddAddressAppService
    {
        private readonly ICustomerRepository _customerRepository;

        public AddAddressAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public int Execute(AddAddressInputModel model)
        {
            // step-1 : add new address to customer addresses
            // step-2 : get list of cities and set city id to customer address

            var newAddressId = _customerRepository.AddAddress(model);
            return newAddressId;

        }
    }
}
