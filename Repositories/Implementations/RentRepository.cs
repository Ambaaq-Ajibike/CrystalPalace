using CrystalPalace.Entities;
using CrystalPalace.Repositories.Interfaces;

namespace CrystalPalace.Repositories.Implementations
{
    public class RentRepository : IRentRepository
    {
        private static List<Rent> Rents = new();

        public Rent AddRent(Rent rent)
        {
            Rents.Add(rent);
            return rent;
        }

        public List<Rent> GetAllRents()
        {
            return Rents;
        }

        public Rent GetRent(Guid id)
        {
            return Rents.FirstOrDefault(r => r.Id == id);
        }
    }
}