using ECommerce.Services.ProductService.DbContext.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Services.ProductService.DbContext
{
    public class ProductDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
