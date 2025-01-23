using Microsoft.AspNetCore.Identity;
using UserManagement.Models;

namespace UserManagement.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserManager<AppUser> _userManager;

        public UserRepository(UserManager<AppUser> userManager)
        {
            this._userManager = userManager;
        }
        public async Task<AppUser?> CreateUser(AppUser user, string password)
        {
            var res = await _userManager.CreateAsync(user, password);
            if (res.Succeeded) {
                return user;
            }
            return null;
        }
    }
}
