using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentCookies.Models
{
    interface IPayment
    {
        void GetPaymentInfo();
        void PrintReceipt();
        bool ValidatePayment();
    }
}
