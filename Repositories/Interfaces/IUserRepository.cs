using CrystalPalace.Entities;

namespace CrystalPalace.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Guid AddUser(User user);
        User GetUser(Guid id);
        Guid UpdateUser(User user);
        User GetUserByEmailAndPassword(string email, string password);
    }
}
