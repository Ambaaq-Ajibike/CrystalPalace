using System.Formats.Asn1;
using CrystalPalace.Entities;
using CrystalPalace.Exceptions;
using CrystalPalace.Repositories.Interfaces;

namespace CrystalPalace.Repositories.Implementations
{
    public class ApartmentRepository : IApartmentRepository
    {
        public static List<Apartment> Apartments = new List<Apartment>()
        {
            // new Apartment(
            //     Guid.NewGuid(),
            //     "Anu",
            //     500000,
            //     38.55,
            //     45.77,
            //     new Address
            //     {
            //         StreetName = "Adeoti street",
            //         LocalGovernmentArea = "Odeda",
            //         State = "Ogun",
            //         Country = "Nigeria"
            //     },
            //     "For living alone"
            // )
            // {
            //     Utilities = new Dictionary<string, int>
            //     {
            //         { "Water", 1 },
            //         { "Electricity", 1 }
            //     },
            //     Images = new List<string>
            //     {
            //         "image1.jpg"
            //     },
            //     Videos = new List<string>
            //     {
            //         "video1.mp4"
            //     }
            // }
        };

        public Guid AddApartment(Apartment apartment)
        {
            Apartments.Add(apartment);
            return apartment.Id;
        }

        public Apartment GetApartmentById(Guid id)
        {
            var apartment = Apartments.FirstOrDefault(x => x.Id == id);
            if (apartment == null)
            {
                throw new NotFoundException("Apartment not found.");
            }
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
            Console.WriteLine("-----------All available Apartments----------");
            if (Apartments.Count == 0)
            {
                Console.WriteLine("No apartments available.");
            }

            foreach (var apartment in Apartments)
            {
                Console.WriteLine($"Apartment Id: {apartment.Id} | Apartment Name: {apartment.Name} | Apartment Price: {apartment.Price} | Address: {apartment.Address}.");
            }
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

        public void GetApartmentDetails(Guid id, string name, decimal price, double? longitude, double? latitude, Address? address, Dictionary<string, int> utilities, List<string> images, List<string> videos, string description)
        {
            var apartment = Apartments.FirstOrDefault(x => x.Id == id);
            if (apartment == null)
            {
                Console.WriteLine("Apartment not found with that Id.");
                return;
            }

            Console.WriteLine($"Apartment Id: {apartment.Id}");
            Console.WriteLine($"Apartment Name: {apartment.Name}");
            Console.WriteLine($"Apartment Price: {apartment.Price}");
            Console.WriteLine($"Logitude : {apartment.Longitude}");
            Console.WriteLine($"Latitude: {apartment.Latitude}");
            Console.WriteLine($"Address: {apartment.Address}");
            Console.WriteLine($"Apartment Facilities: {apartment.Utilities}");
            Console.WriteLine($"Description: {apartment.Description}");
            Console.WriteLine($"Apartment Images: {apartment.Images}");
            Console.WriteLine($"Apartment Videos: {apartment.Videos}");
        }

    }
}