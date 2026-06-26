using CrystalPalace.Repositories.Implementations;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Implementations;
using CrystalPalace.Services.Interfaces;

IUserRepository userRepository = new UserRepository();

IUserService userService = new UserService(userRepository);

Console.WriteLine(
    "------------------Welcome to crystal palace, Where Your needs are satisfied--------------"
);

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1. Register");
    Console.WriteLine("2. Login");
    Console.WriteLine("3. Exit");

    Console.Write("Choose Option: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phone = Console.ReadLine();

            Console.WriteLine(userService.Register(firstName, lastName, email, password, phone));
            break;
        }

        case 2:
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            string response = userService.Login(email, password);

            Console.WriteLine(response);

            if (response == "Login successful")
            {
                Console.WriteLine();
                Console.WriteLine("1. Tenant");
                Console.WriteLine("2. Agent");

                Console.Write("Choose: ");
                int role = int.Parse(Console.ReadLine());

                switch (role)
                {
                    case 1:
                    {
                        bool logout = false;

                        while (!logout)
                        {
                            Console.WriteLine();
                            Console.WriteLine("---------- TENANT MENU ---------");
                            Console.WriteLine("1. Book Visitation");
                            Console.WriteLine("2. Complete Visitation");
                            Console.WriteLine("3. View Apartments");
                            Console.WriteLine("4. Logout");

                            Console.Write("Choose: ");
                            int tenantOption = int.Parse(Console.ReadLine());

                            switch (tenantOption)
                            {
                                case 1:
                                    Console.WriteLine("Book Visitation");
                                    break;

                                case 2:
                                    Console.WriteLine("Complete Visitation");
                                    break;

                                case 3:
                                    Console.WriteLine("View Apartments");
                                    break;

                                case 4:
                                    logout = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }
                        }

                        break;
                    }

                    case 2:
                    {
                        bool logout = false;

                        while (!logout)
                        {
                            Console.WriteLine();
                            Console.WriteLine("-------- AGENT MENU --------");
                            Console.WriteLine("1. Add Apartment");
                            Console.WriteLine("2. View Apartments");
                            Console.WriteLine("3. Logout");

                            Console.Write("Choose: ");
                            int agentOption = int.Parse(Console.ReadLine());

                            switch (agentOption)
                            {
                                case 1:
                                    Console.WriteLine("Add Apartment");
                                    break;

                                case 2:
                                    Console.WriteLine("View Apartments");
                                    break;

                                case 3:
                                    logout = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid Option");
                                    break;
                            }
                        }

                        break;
                    }

                    default:
                        Console.WriteLine("Invalid Role");
                        break;
                }
            }

            break;
        }

        case 3:
            Console.WriteLine("Thank you for using Crystal Palace.");
            return;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }
}
