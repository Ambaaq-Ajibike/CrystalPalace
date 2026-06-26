using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrystalPalace.Entities;

namespace CrystalPalace.Repositories.Interfaces
{
    public interface IVisitationRepository
    {
        Guid BookVisitation(Guid userId, Guid apartmentId, Guid paymentId);
        bool CompleteVisitation(Guid visitationId);
    }
}
