using System;
using System.Threading.Tasks;
using ECommerce.Contracts;
using Grpc.Core;
using static ECommerce.Contracts.ProductService;
using ECommerce.Services.ProductService.DbContext;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Collections.Generic;

namespace ECommerce.Services.ProductService.Repositories
{
    public class ProductRepository : ProductServiceBase
    {
        private IServiceProvider _serviceProvider;
        private readonly IMapper _mapper;

        public ProductRepository(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _mapper = serviceProvider.GetRequiredService<IMapper>();
        }

        public override async Task<GetProductsResponse> GetProducts(Empty request, ServerCallContext context)
        {
            var dbContext = _serviceProvider.GetRequiredService<ProductDbContext>();

            var products = await dbContext
                .Products
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);

            return new GetProductsResponse
            {
                Products = { _mapper.Map<IEnumerable<Product>>(products) }
            };
        }

        public override async Task<GetProductsResponse> GetProductsByFamilyAsync(GetProductsByFamilyRequest request, ServerCallContext context)
        {
            var dbContext = _serviceProvider.GetRequiredService<ProductDbContext>();

            var products = await dbContext
                .Products
                .AsNoTracking()
                .Where(x => (int)x.ProductFamily == (int)request.ProductFamily)
                .ToListAsync()
                .ConfigureAwait(false);

            return new GetProductsResponse
            {
                Products = { _mapper.Map<IEnumerable<Product>>(products) }
            };      
        }
    }
}
