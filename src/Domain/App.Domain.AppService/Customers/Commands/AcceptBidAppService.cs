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
    public class AcceptBidAppService : IAcceptBidAppService
    {

        private readonly ICustomerRepository _customerRepository;

        public AcceptBidAppService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Execute(AcceptBidInputModel model)
        {
            // step-1 : set status of this bid that exist in AcceptBidInputModel to accepted
            // step-2 : set status of other bids to failed

            _customerRepository.AcceptBid(model);

        }
    }
}
