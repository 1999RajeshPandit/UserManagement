using Microsoft.AspNetCore.Identity;

namespace UserManagement.Models
{
    public class AppUser: IdentityUser
    {
        public string City {  get; set; }
        public string CompanyName { get; set; }
    }
}
