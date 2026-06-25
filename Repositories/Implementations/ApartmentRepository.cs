using CrystalPalace.Entities;
using CrystalPalace.Exceptions;
using CrystalPalace.Repositories.Interfaces;

namespace CrystalPalace.Repositories.Implementations
{
    public class ApartmentRepository : IApartmentRepository
    {
        public static List<Apartment> Apartments = [];
        public Guid AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
            return apartment.ApartmentId;
        }

        Apartment GetApartmentById(Guid id)
        {
            var apartment = Apartments.FirstOrDefault(x => x.ApartmentId == id);
            return apartment;
        }

        public void UpdateApartment(Apartment apartment)
        {
            if (apartment == null)
                throw new ArgumentNullException(nameof(apartment));

            var existingApartment = Apartments.FirstOrDefault(a => a.ApartmentId == apartment.ApartmentId);
            if (existingApartment == null)
            {
                throw new Exception("Apartment not found.");
            }

            existingApartment.AgentId = apartment.AgentId;
            existingApartment.Longitude = apartment.Longitude;
            existingApartment.Latitude = apartment.Latitude;
            existingApartment.Address = apartment.Address;
            existingApartment.Utilities = apartment.Utilities;
            existingApartment.Description = apartment.Description;
        }

        List<Apartment> GetApartmentsByAgentId(Guid agentId)
        {
            var apartments = Apartments.Where(x => x.AgentId == agentId).ToList();
            return apartments;
        }

        List<Apartment> GetAll()
        {
            return Apartments;
        }

        void DeleteApartment(Guid id)
        {
            var apartment = Apartments.FirstOrDefault(x => x.ApartmentId == id);
            if (apartment == null)
            {
                throw new NotFoundException("Apartment not found");
            }
            Apartments.RemoveAll(x => x.ApartmentId == id);
        }

    }
}