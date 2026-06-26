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
        public VisitationStatus Status;
        public string Code;
        public Visitation(Guid userId, Guid apartmentId, Guid paymentId)
        {
            VisitationId = Guid.NewGuid();
            UserId = userId;
            ApartmentId = apartmentId;
            Payment = 10000;
            DateVisited = DateTime.Now;
            Status = VisitationStatus.JustBooked;
            PaymentId = paymentId;
            Random random = new();
            Code = $"CPV-{random.Next(10000, 99999)}";
        }
    }
}
