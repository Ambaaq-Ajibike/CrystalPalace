namespace CrystalPalace.Entities
{
    public class User
    {
        public Guid Id;
        public string Firstname;
        public string Lastname;
        public string Email;
        public string Password;
        public string PhoneNumber;

        public User(string firstname, string lastname, string email, string password, string phoneNumber)
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
