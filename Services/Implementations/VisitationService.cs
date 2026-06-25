using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Interfaces;

namespace CrystalPalace.Services.Implementations
{
    public class VisitationService(IVisitationRepository _visitationRepository) : IVisitationService
    {
        public Guid BookVisitation(Guid tenantId, Guid apartmentId)
        {
            return _visitationRepository.BookVisitation(tenantId, apartmentId);
        }

        public bool CompleteVisitation(Guid visitationId)
        {
            return _visitationRepository.CompleteVisitation(visitationId);
        }
    }
}
