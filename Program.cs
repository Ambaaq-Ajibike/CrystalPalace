using CrystalPalace.Repositories.Implementations;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Implementations;
using CrystalPalace.Services.Interfaces;

IUserRepository userRepository = new UserRepository();
IVisitationRepository visitationRepository = new VisitationRepository();
IApartmentRepository apartmentRepository = new ApartmentRepository();

IUserService userService = new UserService(userRepository);
IVisitationService visitationService = new VisitationService(visitationRepository);
IApartmentService apartmentService = new ApartmentService(apartmentRepository);
AuthMenu authMenu = new AuthMenu(userService, visitationService, apartmentService);

Console.WriteLine("------------------Welcome to crystal palace, Where Your needs are satisfied--------------");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("Press to 1. Register");
    Console.WriteLine("\t 2. Login");
    Console.WriteLine("\t 3. Exit");

    Console.Write("Choose Option: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
        {
            authMenu.Register();
            break;
        }

        case 2:
        {
            BaseResponse<Guid> response = authMenu.Login();
            if (response.Status)
            {
              authMenu.Proceed();
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
