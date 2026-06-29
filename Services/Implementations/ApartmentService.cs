using CrystalPalace.Entities;
using CrystalPalace.Exceptions;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Interfaces;

namespace CrystalPalace.Services.Implementations
{
    public class ApartmentService(IApartmentRepository apartmentRepository) : IApartmentService
    {
        public Guid AddApartment(Apartment apartment)
        {
            
            return apartmentRepository.AddApartment(apartment);
        }

        public Apartment GetApartmentById(Guid id)
        {
            var apartment = apartmentRepository.GetApartmentById(id);
            if (apartment == null)
            {
                throw new NotFoundException($"Apartment not found");
            }
            return apartment;
        }

        public Guid UpdateApartment(Apartment apartment)
        {
            return apartmentRepository.UpdateApartment(apartment);
        }

        public List<Apartment> GetApartmentsByAgentId(Guid agentId)
        {
            return apartmentRepository.GetApartmentsByAgentId(agentId);
        }

        public List<Apartment> GetAll()
        {
            return apartmentRepository.GetAll();
        }

        public void DeleteApartment(Guid id)
        {
            apartmentRepository.DeleteApartment(id);
        }

        public void GetApartmentDetails(Guid id, string name, decimal price, double? longitude, double? latitude, Address? address, Dictionary<string, int> utilities, List<string> images, List<string> videos, string description)
        {
            apartmentRepository.GetApartmentDetails(id, name, price, longitude, latitude, address, utilities, images, videos, description);
        }
    }
}
