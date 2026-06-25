using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrystalPalace.Entities;

namespace CrystalPalace.Repositories.Interfaces
{
    public interface ITenantRepository
    {
        Guid AddTenant(Tenant tenant);
        Tenant GetTenant(Guid id);
        Guid UpdateTenat(Tenant tenant);
        Tenant GetTenantByEmailAndPassword(string email, string password);
    }
}
