using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentCookies.Models
{
    public class CreditCard:IPayment
    {
        public string Number { get; set; }
        public string Name { get; set; }
        public DateTime ExperationDate { get; set; }
        public string CVC { get; set; }
        public string ZipCode { get; set; }

        public void GetPaymentInfo()
        {
            throw new NotImplementedException();
        }

        public void PrintReceipt()
        {
            throw new NotImplementedException();
        }

        public bool ValidatePayment()
        {
            throw new NotImplementedException();
        }
    }
}
