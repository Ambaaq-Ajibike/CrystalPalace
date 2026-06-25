using CrystalPalace.Entities;
using CrystalPalace.Exceptions;
using CrystalPalace.Repositories.Interfaces;

namespace CrystalPalace.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        public static List<User> Users = [];

        public Guid AddUser(User user)
        {
            Users.Add(user);
            return user.Id;
        }

        public User GetUser(Guid id)
        {
            var user = Users.FirstOrDefault(x => x.Id == id);
            return user;
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            var user = Users.FirstOrDefault(x => x.Email == email && x.Password == password);
            return user;
        }

        public Guid UpdateUser(User user)
        {
            var userDetails = Users.FirstOrDefault(x => x.Id == user.Id);
            if (userDetails != null)
            {
                throw new NotFoundException("User not found");
            }
            Users.RemoveAll(x => x.Id == user.Id);
            Users.Add(user);
            return user.Id;
        }
    }
}
