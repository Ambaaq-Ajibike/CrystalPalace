using CrystalPalace.Entities;
using CrystalPalace.Services.Interfaces;

namespace CrystalPalace.Entities.Menu
{
    public class ApartmentMenu
    {
        private readonly IApartmentService _apartmentService;

        public ApartmentMenu(IApartmentService apartmentService)
        {
            _apartmentService = apartmentService;
        }

        public void OnboardApartment(Guid agentId)
        {
            Console.WriteLine("===== Apartment Onboarding =====");

            Console.Write("Apartment Name: ");
            string name = Console.ReadLine();

            Console.Write("Description: ");
            string description = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());


            Console.WriteLine("\nLocation");
            Console.WriteLine("1. Enter Address");
            Console.WriteLine("2. Enter Geolocation");
            Console.Write("Choice: ");

            int choice = int.Parse(Console.ReadLine());


            Address? address = null;
            double? latitude = null;
            double? longitude = null;


            if (choice == 1)
            {
                Console.Write("Street Name: ");
                string street = Console.ReadLine();

                Console.Write("Local Government Area: ");
                string lga = Console.ReadLine();

                Console.Write("State: ");
                string state = Console.ReadLine();

                Console.Write("Country: ");
                string country = Console.ReadLine();


                address = new Address
                {
                    StreetName = street,
                    LocalGovernmentArea = lga,
                    State = state,
                    Country = country
                };
            }
            else if (choice == 2)
            {
                Console.Write("Latitude: ");
                latitude = double.Parse(Console.ReadLine());

                Console.Write("Longitude: ");
                longitude = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Invalid option");
                return;
            }


            Apartment apartment = new Apartment(
                agentId,
                name,
                price,
                longitude,
                latitude,
                address,
                description
            );


            Console.WriteLine("\nDo you want to add apartment images?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.Write("Choice: ");

            int imageChoice = int.Parse(Console.ReadLine());


            if (imageChoice == 1)
            {
                Console.WriteLine(
                    "Enter image paths/URLs. Maximum of 5 images."
                );

                while (true)
                {
                    Console.Write("Image: ");
                    string image = Console.ReadLine();

                    if (image.ToLower() == "done")
                    {
                        break;
                    }

                    apartment.Images.Add(image);
                }
            }


            Guid id = _apartmentService.AddApartment(apartment);


            Console.WriteLine("\nApartment onboarded successfully.");
            Console.WriteLine($"Apartment Id: {id}");
            Console.WriteLine($"Images Added: {apartment.Images.Count}");
        }
    }
}