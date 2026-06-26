using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Entities
{
    public class Visitation
    {
        public Guid VisitationId;
        public Guid UserId;
        public Guid ApartmentId;
        public Guid PaymentId;
        public decimal Payment;
        public DateTime DateVisited;
        public bool Status;

        public Visitation(Guid userId, Guid apartmentId, Guid paymentId)
        {
            VisitationId = Guid.NewGuid();
            UserId = userId;
            ApartmentId = apartmentId;
            Payment = 10000;
            DateVisited = DateTime.Now;
            Status = false;
            PaymentId = paymentId;
        }
    }
}
