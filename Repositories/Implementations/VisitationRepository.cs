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

        public string BookVisitation(Guid tenantId, Guid apartmentId, Guid paymentId)
        {
            var visitation = new Visitation(tenantId, apartmentId, paymentId);

            Visitations.Add(visitation);

            return visitation.Code;
        }

        public bool CompleteVisitation(string code)
        {
            var visitation = Visitations.FirstOrDefault(x => x.Code == code);

            if (visitation == null)
            {
                return false;
            }

            visitation.Status = VisitationStatus.Visited;

            return true;
        }
    }
}
