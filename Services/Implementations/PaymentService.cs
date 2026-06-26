using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Interfaces;

namespace CrystalPalace.Services.Implementations
{
    public class PaymentService: IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService( IPaymentRepository paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }

        public void MakePayment(Payment payment)
        {
            _paymentRepository.AddPayment(payment);
        }

        public List<Payment> GetAllPayments()
        {
            return _paymentRepository.GetPayments();
        }
    }
}