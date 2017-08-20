using AutoMapper;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ECommerce.Tests.Frontend
{
    public class ServiceProvider
    {
        //internal static IServiceProvider GetServiceProvider(Action<EComDbContext> seedDataAction)
        //{
        //    var serviceCollection = new ServiceCollection();
            
        //    serviceCollection.AddAutoMapper(RegisterFrontendAndBackendMapper);
        //    serviceCollection.AddTransient<EComDbContext>(provider =>
        //    {
        //        var options = new DbContextOptionsBuilder().UseInMemoryDatabase("EComTestDb").Options; 

        //        var dbContext = new EComDbContext(options);

        //        seedDataAction(dbContext);

        //        return dbContext;
        //    });

        //    return serviceCollection.BuildServiceProvider();
        //}

        //private static void RegisterFrontendAndBackendMapper(IMapperConfigurationExpression conf)
        //{
        //    ECommerce.Frontend.AppStart.AutoMapperConfig.ConfigureMapper(conf);
        //    //ECommerce.Backend.AppStart.AutoMapperConfig.ConfigureMapper(conf);
        //}
    }
}
