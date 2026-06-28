using System;
using System.Collections.Generic;
using CrystalPalace.Entities;
using CrystalPalace.Services.Interfaces;

namespace CrystalPalace.Menus
{
    public class PaymentMenu
    {
        private readonly IPaymentService _paymentService;

        public PaymentMenu(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        public void ShowMenu()
        {
            Console.WriteLine("1. Make Payment");
            Console.WriteLine("2. Get All Payments");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Tenant: ");
                    string tenant = Console.ReadLine();

                    Console.Write("Enter Apartment: ");
                    string apartment = Console.ReadLine();

                    Console.Write("Enter Payment Type: ");
                    string paymentType = Console.ReadLine();

                    Console.Write("Enter Payment Type Id: ");
                    string paymentTypeId = Console.ReadLine();

                    Payment payment = new Payment(tenant, apartment, paymentType, paymentTypeId);

                    _paymentService.CreatePayment(payment);

                    Console.WriteLine("Payment Successful!");
                    break;

                case 2:
                    List<Payment> payments = _paymentService.GetAllPayments();

                    foreach (var item in payments)
                    {
                        Console.WriteLine($"{item.Tenant} - {item.Apartment} - {item.PaymentType} - {item.PaymentTypeId}");
                    }
                    break;
            }
        }
    }
}