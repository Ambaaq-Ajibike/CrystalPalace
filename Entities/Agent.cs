namespace CrystalPalace.Entities
{
    public class Agent : User
    {
        public Guid AgentId;
        public string AgencyStatus;

        public Agent(string firstname, string lastname, string email, string password, string phoneNumber, string agencyStatus) : base(firstname, lastname,email,password,phoneNumber)
        {
            Id = Guid.NewGuid();
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
            AgentId = Guid.NewGuid();
            AgencyStatus = agencyStatus;
        }
    }
}