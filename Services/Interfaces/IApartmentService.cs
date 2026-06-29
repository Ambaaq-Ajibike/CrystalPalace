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
        void GetApartmentDetails(Guid id, string name, decimal price, double? longitude, double? latitude, Address? address, Dictionary<string, int> utilities, List<string> images, List<string> videos, string description);
    }
}
