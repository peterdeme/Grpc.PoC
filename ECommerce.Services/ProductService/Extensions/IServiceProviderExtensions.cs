using System;
using Microsoft.Extensions.DependencyInjection;
using ECommerce.Services.ProductService.DbContext;
using ECommerce.Services.ProductService.DbContext.Entities;

namespace ECommerce.Services.ProductService.Extensions
{
    public static class IServiceProviderExtensions
    {
        public static IServiceProvider SeedDatabase(this IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetRequiredService<ProductDbContext>();

            dbContext.Products.AddRange(
                new ProductEntity
                {
                    Id = 0,
                    ProductFamily = ProductFamily.CollaborationTool,
                    ProductName = "JoinMe"
                
                },
                new ProductEntity
                {
                    Id = 2,
                    ProductFamily = ProductFamily.CollaborationTool,
                    ProductName = "GetStopPro"
                }
            );

            dbContext.SaveChanges();

            return serviceProvider;
        }
    }
}
