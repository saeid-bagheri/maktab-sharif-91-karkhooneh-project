using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels.Customers
{
    public class AddAddressInputModel
    {
        public int CustomerId { get; set; }
        public bool IsMainAddress { get; set; }
        public int CityId { get; set; }
        public string? CityRegionTitle { get; set; }
        public string? FullAddress { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
    }
}
