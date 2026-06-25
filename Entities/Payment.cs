using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace
{
    public class Payment
    {
        public string Tenant { get; set; }
        public string Apartment { get; set; }
        public string PaymentType { get; set; }
        public string PaymentTypeId { get; set; }

        public Payment(string tenant, string apartment, string paymentType, string paymentTypeId)
        {
            Tenant = tenant;
            Apartment = apartment;
            PaymentType = paymentType;
            PaymentTypeId = paymentTypeId;
        }
    }
}
