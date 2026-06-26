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
        public string BookVisitation(Guid userId, Guid apartmentId, Guid paymentId)
        {
            return _visitationRepository.BookVisitation(userId, apartmentId, paymentId);
        }

        public bool CompleteVisitation(string visitationId)
        {
            return _visitationRepository.CompleteVisitation(visitationId);
        }
    }
}
