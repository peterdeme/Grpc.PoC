using Microsoft.AspNetCore.Hosting;
using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Http;
using ECommerce.Services.UserService.DbContext;
using Microsoft.EntityFrameworkCore;
using ECommerce.Services.UserService.AppStart;
using AutoMapper;

namespace ECommerce.Services.UserService
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
            services.AddDbContextPool<UserDbContext>(opts => opts.UseInMemoryDatabase("UserServiceDb"));
            services.AddAutoMapper(AutoMapperConfig.ConfigureMapper);

            return services.BuildServiceProvider();
        }
    }
}
