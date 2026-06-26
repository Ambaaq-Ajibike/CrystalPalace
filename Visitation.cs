using System;
using System.Data.Common;
using CrystalPalace.Entities;
using CrystalPalace.Repositories.Implementations;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Implementations;
using CrystalPalace.Services.Interfaces;


namespace CrystalPalace
{
    public static class VisitationFlow
    {
        public static void Run()
        {
            IUserRepository userRepository = new UserRepository();
            IUserService userService = new UserService(userRepository);
            ITenantRepository tenantRepository = new TenantRepository();
            IVisitationRepository visitationRepository = new VisitationRepository();
            IVisitationService visitationService = new VisitationService(visitationRepository);

            Console.WriteLine("------- Visitation Booking ------");

            Console.Write("Enter your Email: ");
            string emailInput = Console.ReadLine();

            Console.Write("Enter your Password: ");
            string passwordInput = Console.ReadLine();

            var user = userService.GetUserByEmailAndPassword(emailInput, passwordInput);

            if (user == null)
            {
                Console.WriteLine("Invalid email or password. Try again.");
                return;
            }

            Console.WriteLine("User details:");
            Console.WriteLine($"User Id: {user.Id}");
            Console.WriteLine($"First Name: {user.Firstname}");
            Console.WriteLine($"Last Name : {user.Lastname}");
            Console.WriteLine($"Email: {user.Email}");
            Console.WriteLine($"Phone: {user.PhoneNumber}");

            Console.Write("Enter your User Id: ");
            string tenantIdInput = Console.ReadLine();
            Guid tenantId = new Guid(tenantIdInput);

            var tenant = tenantRepository.GetTenant(tenantId);

            if (tenant == null)
            {
                Console.WriteLine("Tenant id does not exist in the system.");
                return;
            }

            Console.Write("Enter the Apartment Id: ");
            string apartmentIdInput = Console.ReadLine();
            Guid apartmentId = new Guid(apartmentIdInput);

            Console.Write("Enter the Payment Id: ");
            string paymentIdInput = Console.ReadLine();
            Guid paymentId = new Guid(paymentIdInput);

            Guid visitationId = visitationService.BookVisitation(tenantId, apartmentId, paymentId);

            if(visitationId == Guid.Empty)
            {
                Console.WriteLine("Visitation booking failed.");
                return;
            }
            bool booked = visitationService.CompleteVisitation(visitationId);

            Console.WriteLine($"Visitation created Successfully.");


            Console.WriteLine(booked ? "Visitation status changed to booked." : "Could not update visitation status to booked.");
        }
    }
}
