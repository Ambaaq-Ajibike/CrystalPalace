using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Services.Interfaces
{
    public interface IVisitationService
    {
        string BookVisitation(Guid userId, Guid apartmentId, Guid paymentId);
        bool CompleteVisitation(string visitationCode);
    }
}
