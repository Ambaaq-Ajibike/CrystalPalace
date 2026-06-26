using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Entities
{
    public class Visitation
    {
        public Guid Id;
        public Guid TenantId;
        public Guid ApartmentId;
        public Guid PaymentId;
        public decimal Payment;
        public DateTime DateVisited;
        public bool Status;

        public Visitation(Guid tenantId, Guid apartmentId)
        {
            Id = Guid.NewGuid();
            TenantId = tenantId;
            ApartmentId = apartmentId;
            Payment = 10000;
            Status = false;
            DateVisited = DateTime.Now;
        }
    }
}
