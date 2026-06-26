using System;
using System.Data.Common;
using CrystalPalace.Entities;
using CrystalPalace.Repositories.Implementations;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Implementations;
using CrystalPalace.Services.Interfaces;


namespace CrystalPalace
{
    public class VisitationMenu(IVisitationService visitationService)
    {
        public void BookVisitation(Guid tenantId)
        {
            Console.Write("Enter the Apartment Id: ");
            string apartmentIdInput = Console.ReadLine();
            Guid apartmentId = new Guid(apartmentIdInput);

            Console.Write("Enter the Payment Id: ");
            string paymentIdInput = Console.ReadLine();
            Guid paymentId = new Guid(paymentIdInput);

            string visitationCode = visitationService.BookVisitation(tenantId, apartmentId, paymentId);
            Console.WriteLine($"Your visitation code is {visitationCode}");
        }
        public void CompleteVisitation(string visitationCode)
        {
            bool booked = visitationService.CompleteVisitation(visitationCode);
            Console.WriteLine(booked ? "Visitation status changed to booked." : "Could not update visitation status to booked.");
        }
    }
    
}
