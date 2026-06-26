using CrystalPalace;
using CrystalPalace.Services.Interfaces;

public class TenantMenu(IVisitationService visitationService, IApartmentService apartmentService){
    VisitationMenu visitationMenu = new VisitationMenu(visitationService);
    public void Proceed(Guid userId){
        bool logout = false;

        while (!logout)
        {
            Console.WriteLine();
            Console.WriteLine("---------- TENANT MENU ---------");
            Console.WriteLine("1. Book Visitation");
            Console.WriteLine("2. Complete Visitation");
            Console.WriteLine("3. View Apartments");
            Console.WriteLine("4. View Apartment Detail");
            Console.WriteLine("5. Logout");

            Console.Write("Choose: ");
            int tenantOption = int.Parse(Console.ReadLine());

            switch (tenantOption)
            {
                case 1:
                    Console.WriteLine("Book Visitation");
                    
                    visitationMenu.BookVisitation(userId);
                    break;

                case 2:
                    Console.WriteLine("Complete Visitation");
                    Console.WriteLine("Enter your visitation code");
                    string visitationCode = Console.ReadLine();
                    visitationMenu.CompleteVisitation(visitationCode);
                    break;
                case 3:
                    Console.WriteLine("View Apartments");
                    apartmentService.GetAll();
                    break;
                case 5:
                    logout = true;
                    break;

                default:
                    Console.WriteLine("Invalid Option");
                    break;
            }
        }

    }
}