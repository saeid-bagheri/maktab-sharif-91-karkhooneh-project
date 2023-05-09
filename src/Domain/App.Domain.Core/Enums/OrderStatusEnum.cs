using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Enums
{
    public enum OrderStatusEnum
    {
        WaitingExpertAdvice = 1,
        WaitingExpertSelection = 2,
        WaitingExpertComeToYourPlace = 3,
        Started = 4,
        Done = 5,
        Paid = 6
    }
}
