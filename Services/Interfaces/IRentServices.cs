using CrystalPalace.Entities;

namespace CrystalPalace.Services.Interfaces
{
    public interface IRentRepository
    {
        Rent AddRent(Rent rent);
        List<Rent> GetAllRents();
        Rent GetRent(Guid id);
    }
}