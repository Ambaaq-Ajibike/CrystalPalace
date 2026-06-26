using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Services.Interfaces
{
    public interface IPaymentService
    {
        void MakePayment(Payment payment);
        List<Payment> GetAllPayments();
    }
}