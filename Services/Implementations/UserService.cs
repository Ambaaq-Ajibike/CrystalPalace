using CrystalPalace.Entities;
using CrystalPalace.Repositories.Interfaces;
using CrystalPalace.Services.Interfaces;

namespace CrystalPalace.Services.Implementations
{
    public class UserService(IUserRepository _userRepository) : IUserService
    {
        public string Login(string email, string password)
        {
            var user = _userRepository.GetUserByEmailAndPassword(email, password);
            return user == null ? "User not found" : "Login successful";
        }

        public string Register(string firstName, string lastName, string email, string password, string phone)
        {
            var user = new User(firstName, lastName, email, password, phone);
            _userRepository.AddUser(user);
            return "User Created Successfully";
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _userRepository.GetUserByEmailAndPassword(email, password);
        }
    }
}
