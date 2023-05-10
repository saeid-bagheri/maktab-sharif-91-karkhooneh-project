using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.DtoModels.Customers
{
    public class AcceptBidInputModel
    {
        public int BidId { get; set; }
        public int OrderId { get; set; }
    }
}
