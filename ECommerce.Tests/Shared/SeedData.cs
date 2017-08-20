
using ECommerce.Services.UserService.DbContext;
using ECommerce.Services.UserService.DbContext.Entities;
using System.Collections.Generic;

namespace ECommerce.Tests.Shared
{
    public class SeedData
    {
        public static List<UserEntity> Users = null;

        static SeedData()
        {
            Users = new List<UserEntity>
            {
                new UserEntity
                {
                     Id= 0,
                     FirstName = "Wazovski",
                      DateOfBirth = new System.DateTime(1993,12,20),
                      LastName = "Mike"
                }
            };
        }

        public static void PopulateDbContext(UserDbContext dbContext)
        {
            dbContext.Users.AddRange(Users);

            dbContext.SaveChanges();
        }
    }
}
