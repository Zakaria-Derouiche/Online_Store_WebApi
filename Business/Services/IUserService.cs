using Data.Models;
using Microsoft.AspNetCore.Identity;

namespace Business.Services
{
    public interface IUserService
    {

        Task<IdentityResult> RegisterUserAsync(RegisterModel model);
        
    }
}
