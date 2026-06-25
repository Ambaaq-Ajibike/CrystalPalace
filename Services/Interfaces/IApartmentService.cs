using CrystalPalace.Entities;
using CrystalPalace.Repositories.Interfaces;
namespace CrystalPalace.Services.Interfaces
{
    public interface IApartmentService
    {
        Guid AddApartment(Apartment apartment);
        Apartment GetApartmentById(Guid id);
        Guid UpdateApartment(Apartment apartment);
        List<Apartment> GetApartmentsByAgentId(Guid agentId);
        List<Apartment> GetAll();
        void DeleteApartment(Guid id);
    }
}
