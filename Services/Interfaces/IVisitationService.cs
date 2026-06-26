using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Services.Interfaces
{
    public interface IVisitationService
    {
        Guid BookVisitation(Guid userId, Guid apartmentId, Guid paymentId);
        bool CompleteVisitation(Guid visitationId);
    }
}
