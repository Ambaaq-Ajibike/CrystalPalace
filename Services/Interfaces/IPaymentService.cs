using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Services.Interfaces
{
    public interface IPaymentService
    {
        void CreatePayment(Payment payment);
        List<Payment> GetAllPayments();
    }
}