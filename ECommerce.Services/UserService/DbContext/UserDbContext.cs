using ECommerce.Services.UserService.DbContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Services.UserService.DbContext
{
    public class UserDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public UserDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<UserEntity> Users { get; set; }
    }
}
