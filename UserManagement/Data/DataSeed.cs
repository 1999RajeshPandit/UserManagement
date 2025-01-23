using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace UserManagement.Data
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            var readerRoleId = "671a54ad-b934-4c7a-a6be-b2c6e0c5d252";
            var writerRoleId = "29af16ae-7922-4370-9ed5-fcf8f1d64b94";

            var roles = new List<IdentityRole>{
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "reader",
                    NormalizedName="Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "writer",
                    NormalizedName="Writer".ToUpper()
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
