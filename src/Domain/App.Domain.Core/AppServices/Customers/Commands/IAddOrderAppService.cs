using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core.DtoModels.Customers;

namespace App.Domain.Core.AppServices.Customers.Commands
{
    public interface IAddOrderAppService
    {
        int Execute(AddOrderInputModel model);
    }
}
