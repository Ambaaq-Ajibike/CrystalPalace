using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrystalPalace.Entities;
using CrystalPalace.Exceptions;

namespace CrystalPalace.Repositories.Implementations
{
    public class TenantRepository
    {
        public static List<Tenant> Tenants = [];

        public Guid AddTenant(Tenant tenant)
        {
            Tenants.Add(tenant);
            return tenant.Id;
        }

        public Tenant GetTenant(Guid id)
        {
            var tenant = Tenants.FirstOrDefault(x => x.Id == id);
            return tenant;
        }

        public Tenant GetTenantByEmailAndPassword(string email, string password)
        {
            var tenant = Tenants.FirstOrDefault(x => x.Email == email && x.Password == password);
            return tenant;
        }

        public Guid UpdateTenant(Tenant tenant)
        {
            var tenantDetails = Tenants.FirstOrDefault(x => x.Id == tenant.Id);
            if (tenantDetails != null)
            {
                throw new NotFoundException("Tenant not found");
            }
            Tenants.RemoveAll(x => x.Id == tenant.Id);
            Tenants.Add(tenant);
            return tenant.Id;
        }
    }
}
