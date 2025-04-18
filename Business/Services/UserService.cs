using Data.Models;
using Data.Repositories;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Business;
using Online_Store_Api;



namespace Business.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;

        public UserService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<AuthModel> RegisterUserAsync(RegisterModel model)
        {
            if (await _userManager.FindByEmailAsync(model.Email) is not null)
            {
                return new AuthModel { Message = "Email Already Exist" };
            }
            if (await _userManager.FindByEmailAsync(model.UserName) is not null)
            {
                return new AuthModel { Message = "Email Already Exist" };
            }
            var user = new User { 
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
            };
            var result = await _userManager.CreateAsync(user);

            if (!result.Succeeded)
            {
                var errors = string.Join(",", result.Errors.Select(e => e.Description));
                return new AuthModel { Message = errors };
            }
            await _userManager.AddToRoleAsync(user, "User");
        }
    }
}
