using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrystalPalace.Entities
{
    public class Tenant : User
    {
        
        public Tenant(
            string firstname,
            string lastname,
            string email,
            string password,
            string phoneNumber
        )
            : base(firstname, lastname, email, password, phoneNumber)
        {
            Id = Guid.NewGuid();
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            PhoneNumber = phoneNumber;
        }
    }
}
