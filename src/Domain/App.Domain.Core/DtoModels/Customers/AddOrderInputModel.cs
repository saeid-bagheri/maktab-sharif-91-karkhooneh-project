namespace App.Domain.Core.DtoModels.Customers;

public class AddOrderInputModel
{
    public int CustomerId { get; set; }
    public int CustomerAddressId { get; set; }
    public DateTime AvailabilityFrom { get; set; }
    public DateTime AvailabilityTo { get; set; }
    public int ServiceCategoryId { get; set; }
    public List<int> ListOfServiceIds { get; set; }
    public int CreatedByUserId { get; set; }
}