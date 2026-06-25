using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrystalPalace.Repositories.Interfaces;

namespace CrystalPalace.Repositories.Implementations
{
    public class PaymentRepository:IPaymentRepository        
    {
         private List<Payment> payments = new List<Payment>();

        public void AddPayment(Payment payment)
        {
            payments.Add(payment);
        }

        public List<Payment> GetPayments()
        {
            return payments;
        }
    }
}