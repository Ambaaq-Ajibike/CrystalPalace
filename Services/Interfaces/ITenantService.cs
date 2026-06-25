using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Services.Interfaces
{
    public interface ITenantService
    {
        string Register(
            string firstName,
            string lastName,
            string email,
            string password,
            string phone
        );
        string Login(string email, string password);
    }
}
