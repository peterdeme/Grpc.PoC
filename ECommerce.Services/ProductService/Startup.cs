using Microsoft.AspNetCore.Hosting;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using ECommerce.Services.ProductService.DbContext;
using AutoMapper;
using ECommerce.Services.ProductService.AppStart;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Services.ProductService
{
    public class Startup : IStartup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Map("/healthcheck", 
                appBuilder => appBuilder.Run(async context => await context.Response.WriteAsync("YesOk")));
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddDbContextPool<ProductDbContext>(opts => opts.UseInMemoryDatabase("ProductServiceDb"));
            services.AddAutoMapper(AutoMapperConfig.ConfigureMapper);

            return services.BuildServiceProvider();
        }
    }
}
