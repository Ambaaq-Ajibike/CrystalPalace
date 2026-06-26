using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Entities
{
    public class Tenant : User
    {
        public Guid TenantId;

        public Tenant(
            string firstname,
            string lastname,
            string email,
            string password,
            string phoneNumber
        )
            : base(firstname, lastname, email, password, phoneNumber)
        {
            TenantId = Guid.NewGuid();
        }
    }
}
