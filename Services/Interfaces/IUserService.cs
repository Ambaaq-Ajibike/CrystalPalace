using CrystalPalace.Entities;

namespace CrystalPalace.Services.Interfaces
{
    public interface IUserService
    {
        string Register(string firstName, string lastName, string email, string password, string phone);
        BaseResponse<Guid> Login(string email, string password);
        User GetUserByEmailAndPassword(string email, string password);
    }
}
