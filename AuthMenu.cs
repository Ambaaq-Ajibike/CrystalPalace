using CrystalPalace;
using CrystalPalace.Entities;
using CrystalPalace.Services.Interfaces;

public class AuthMenu(IUserService userService, IVisitationService visitationService, IApartmentService apartmentService)
{
    Guid UserId;
    public void Register()
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
    }

    public BaseResponse<Guid> Login(){
        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        BaseResponse<Guid> response = userService.Login(email, password);
        UserId = response.Data;
        return response;
    }
    public void Proceed(){
        Console.WriteLine();
        Console.WriteLine("1. Tenant");
        Console.WriteLine("2. Agent");

        Console.Write("Choose: ");
        int role = int.Parse(Console.ReadLine());

        switch (role)
        {
            case 1:
                {
                    TenantMenu tenantMenu = new TenantMenu(visitationService, apartmentService);
                    tenantMenu.Proceed(UserId);
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
                        Console.WriteLine("2. View Your Apartments");
                        Console.WriteLine("3. Logout");

                        Console.Write("Choose: ");
                        int agentOption = int.Parse(Console.ReadLine());

                        switch (agentOption)
                        {
                            case 1:
                                Console.WriteLine("Add Apartment");
                                break;

                            case 2:
                                Console.WriteLine("View your Apartments");
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
}

