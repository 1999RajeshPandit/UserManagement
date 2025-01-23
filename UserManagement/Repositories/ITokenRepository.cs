using Microsoft.AspNetCore.Identity;

namespace NZWalkAPI.Repositories
{
    public interface ITokenRepository
    {
        string CreateJWTToken(IdentityUser user, List<string> roles);
    }
}
