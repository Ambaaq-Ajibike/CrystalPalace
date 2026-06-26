using CrystalPalace.Entities;
using CrystalPalace.Exceptions;
using CrystalPalace.Repositories.Interfaces;

namespace CrystalPalace.Repositories.Implementations
{
    public class ApartmentRepository : IApartmentRepository
    {
        public static List<Apartment> Apartments = [
        ];
        public Guid AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
            return apartment.Id;
        }

        public Apartment GetApartmentById(Guid id)
        {
            var apartment = Apartments.FirstOrDefault(x => x.Id == id);
            return apartment;
        }

        public Guid UpdateApartment(Apartment apartment)
        {
            if (apartment == null)
                throw new ArgumentNullException(nameof(apartment));

            var existingApartment = Apartments.FirstOrDefault(a => a.Id == apartment.Id);
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
            return existingApartment.Id;
        }

        public List<Apartment> GetApartmentsByAgentId(Guid agentId)
        {
            var apartments = Apartments.Where(x => x.AgentId == agentId).ToList();
            return apartments;
        }

        public List<Apartment> GetAll()
        {
            return Apartments;
        }

        public void DeleteApartment(Guid id)
        {
            var apartment = Apartments.FirstOrDefault(x => x.Id == id);
            if (apartment == null)
            {
                throw new NotFoundException("Apartment not found");
            }
            Apartments.RemoveAll(x => x.Id == id);
        }

    }
}