using System;
using Microsoft.Extensions.DependencyInjection;
using ECommerce.Services.UserService.DbContext;
using ECommerce.Services.UserService.DbContext.Entities;

namespace ECommerce.Services.UserService.Extensions
{
    public static class IServiceProviderExtensions
    {
        public static IServiceProvider SeedDatabase(this IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<UserDbContext>();

            dbContext.Users.AddRange(
                new UserEntity
                {
                    Id = 1,
                    DateOfBirth = new DateTime(1980, 01, 01, 0, 0, 0, DateTimeKind.Utc),
                    FirstName = "Erlich",
                    LastName = "Bachman"
                },
                new UserEntity
                {
                    Id = 2,
                    DateOfBirth = new DateTime(1989, 01, 01, 0, 0, 0, DateTimeKind.Utc),
                    FirstName = "Richard",
                    LastName = "Hendricks"
                }
            );

            dbContext.SaveChanges();

            return serviceProvider;
        }
    }
}
