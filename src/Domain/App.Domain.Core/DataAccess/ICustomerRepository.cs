﻿using App.Domain.Core.DtoModels.Customers;

namespace App.Domain.Core.DataAccess;

public interface ICustomerRepository
{
    int AddOrder(AddOrderInputModel model);
    int AddAddress(AddAddressInputModel model);
    void AcceptBid(AcceptBidInputModel model);
}