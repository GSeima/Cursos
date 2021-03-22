using System;
using System.Collections.Generic;
using System.Text;

namespace TreinamentoDia4.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayment,
        Processing,
        Shipped,
        Delivered
    }
}
