namespace CrystalPalace.Entities
{
    public class Apartment
    {
        public Guid ApartmentId;
        public Guid AgentId;
        public string Name;
        public decimal Price;
        public double? Longitude;
        public double? Latitude;
        public Address? Address;
        public Dictionary<string, int> Utilities;
        public string Description;
        public List<string> Images;

        public Apartment(
            Guid agentId,
            string name,
            decimal price,
            double? longitude,
            double? latitude,
            Address? address,
            string description)
        {
            ApartmentId = Guid.NewGuid();
            AgentId = agentId;
            Name = name;
            Price = price;
            Longitude = longitude;
            Latitude = latitude;
            Address = address;
            Description = description;
            Utilities = new Dictionary<string, int>();
            Images = new List<string>();

            if (Address == null && (Latitude == null || Longitude == null))
            {
                throw new ArgumentException(
                    "An apartment must have either an address or a geolocation."
                );
            }
        }
    }
}