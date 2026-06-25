using CrystalPalace.Repositories.Implementations;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Implementations;
using CrystalPalace.Services.Interfaces;

IUserRepository userRepository = new UserRepository();

IUserService userService = new UserService(userRepository);

Console.WriteLine("------------------Welcome to crystal palace, Where Your needs are satisfied--------------");

while (true)
{
    Console.WriteLine("Press 1 to Register \n Press 2 to Login \n Press 3 to exit");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            Console.Write("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your email: ");
            string email = Console.ReadLine();
            Console.Write("Enter your password: ");
            string password = Console.ReadLine();
            Console.Write("Enter your phone number: ");
            string phone = Console.ReadLine();
            Console.WriteLine(userService.Register(firstName, lastName, email, password, phone));
            break;

        case 2:
            Console.Write("Enter your email: ");
            string loginEmail = Console.ReadLine();
            Console.Write("Enter your password: ");
            string loginPassword = Console.ReadLine();
            Console.WriteLine(userService.Login(loginEmail, loginPassword));
            break;

        default:
            Console.WriteLine("Thank you for visiting crystal Palace");
            break;
    }
}

