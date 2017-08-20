using AutoMapper;
using ECommerce.Contracts;
using ECommerce.Services.ProductService.DbContext.Entities;

namespace ECommerce.Services.ProductService.AppStart
{
    public class AutoMapperConfig
    {
        public static void ConfigureMapper(IMapperConfigurationExpression config)
        {
            config.CreateMap<ProductEntity, Product>();
        }
    }
}
