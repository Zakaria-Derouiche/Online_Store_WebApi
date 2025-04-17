using Data.Models;
using Data.Repositories;
using System.Collections.Generic;

namespace Business.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetAllUsers() => _userRepository.GetAll();

        public User GetUserByID(int id) => _userRepository.GetById(id);

        public void CreateUser(User product)
        {

            _userRepository.Add(product);
        }

        public void UpdateUser(User product)
        {

            _userRepository.Update(product);
        }

        public void DeleteUser(int id) => _userRepository.Delete(id);
    }
}
