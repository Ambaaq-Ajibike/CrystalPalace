using CrystalPalace.Entities;

namespace CrystalPalace.Repositories.Interfaces
{
    public interface IApartmentRepository
    {
        Guid AddApartment(Apartment apartment);
        Apartment GetApartmentById(Guid id);
        Guid UpdateApartment(Apartment apartment);
        List<Apartment> GetApartmentsByAgentId(Guid agentId);
        List<Apartment> GetAll();
        void DeleteApartment(Guid id);
    }
}