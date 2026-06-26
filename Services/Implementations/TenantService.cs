using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrystalPalace.Entities;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Interfaces;

namespace CrystalPalace.Services.Implementations
{
    public class TenantService(ITenantRepository _tenantRepository) : ITenantService
    {
        public string Login(string email, string password)
        {
            var tenant = _tenantRepository.GetTenantByEmailAndPassword(email, password);
            return tenant == null ? "Tenant not found" : "Login successful";
        }

        public string Register(
            string firstName,
            string lastName,
            string email,
            string password,
            string phone
        )
        {
            var tenant = new Tenant(firstName, lastName, email, password, phone);
            _tenantRepository.AddTenant(tenant);
            return "Tenant created sucessfully.";
        }
    }
}
