using App.Domain.Core.DtoModels.Customers;

namespace App.Domain.Core.DataAccess;

public interface ICustomerRepository
{
    int AddOrder(AddOrderInputModel model);
}