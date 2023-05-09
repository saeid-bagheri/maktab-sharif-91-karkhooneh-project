using App.Domain.Core.Entities;

namespace App.Domain.Core.DtoModels.Customers
{
    public class EditCustomerInputModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime? Birthdate { get; set; }

        public int? CityId { get; set; }

        public string MobileNumber { get; set; } = null!;

        public string BackupMobileNumber { get; set; } = null!;

        public int? LastModifiedBy { get; set; }

        public List<CustomerAddress>? customerAddresses { get; set; }
    }
}