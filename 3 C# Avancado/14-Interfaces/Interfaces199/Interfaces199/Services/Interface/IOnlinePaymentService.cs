using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces199.Services.Interface
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);

        double Interest(double amount, int months);

    }
}
