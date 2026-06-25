//entities, services(interface), repository
namespace CrystalPalace.Entities
{
    public class Apartment
    {
        public Guid ApartmentId;
        public Guid AgentId;
        public double Longitude;
        public double Latitude;
        public Address Address;
        public Dictionary<string, int> Utilities;
        public string Description;

        public Apartment(Guid agentId, double longitude, double latitude, Address address, string description)
        {
            ApartmentId = Guid.NewGuid();
            AgentId = agentId;
            Longitude = longitude;
            Latitude = latitude;
            Address = address;
            Utilities = new Dictionary<string, int>();
            Description = description;
        }

    }
}