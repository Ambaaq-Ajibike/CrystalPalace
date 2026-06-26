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

        public Guid BookVisitation(Guid userId, Guid apartmentId)
        {
            var visitation = new Visitation(userId, apartmentId);

            Visitations.Add(visitation);

            return visitation.VisitationId;
        }

        public bool CompleteVisitation(Guid visitationId)
        {
            var visitation = Visitations.FirstOrDefault(x => x.VisitationId == visitationId);

            if (visitation == null)
            {
                return false;
            }

            visitation.Status = true;

            return true;
        }
    }
}
