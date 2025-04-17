using Data.Models;

namespace Business.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        User GetUserByID(int id);
        void CreateUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}
