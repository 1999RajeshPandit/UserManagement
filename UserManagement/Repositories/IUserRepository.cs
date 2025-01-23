using UserManagement.Models;

namespace UserManagement.Repositories
{
    public interface IUserRepository
    {
       Task<AppUser?> CreateUser(AppUser user, string password);
    }
}
