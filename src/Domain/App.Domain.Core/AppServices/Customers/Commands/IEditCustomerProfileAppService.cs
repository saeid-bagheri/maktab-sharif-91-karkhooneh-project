﻿using App.Domain.Core.DtoModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.AppServices.Customers.Commands
{
    public interface IEditCustomerProfileAppService
    {
        int Execute(EditCustomerInputModel model);
    }
}
