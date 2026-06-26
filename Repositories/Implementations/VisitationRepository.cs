using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrystalPalace.Entities;
using CrystalPalace.Repositories.Interfaces;

namespace CrystalPalace.Repositories.Implementations
{
    public class VisitationRepository : IVisitationRepository
    {
        public static List<Visitation> Visitations = [];

        public Guid BookVisitation(Guid tenantId, Guid apartmentId, Guid paymentId)
        {
            var visitation = new Visitation(tenantId, apartmentId)
            {
                PaymentId = paymentId
            };

            Visitations.Add(visitation);

            return visitation.Id;
        }

        public bool CompleteVisitation(Guid visitationId)
        {
            var visitation = Visitations.FirstOrDefault(x => x.Id == visitationId);

            if (visitation == null)
            {
                return false;
            }

            visitation.Status = true;

            return true;
        }
    }
}
