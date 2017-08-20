using System;
using Grpc.Core;
using ECommerce.Contracts.Configuration;
using ECommerce.Services.ProductService.Extensions;
using ECommerce.Services.ProductService.Repositories;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System.Threading.Tasks;

namespace ECommerce.Services.ProductService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = StartKestrel().SeedDatabase();

            Server server = new Server
            {
                Services = {
                    Contracts.ProductService.BindService(new ProductRepository(serviceProvider) )
                },
                Ports = { { "0.0.0.0", SharedConstants.GRPC.ProductServiceBackendPortNumber, ServerCredentials.Insecure } }
            };

            server.Start();

            Console.WriteLine("Server listening on port " + SharedConstants.GRPC.ProductServiceBackendPortNumber);
            Console.WriteLine("Press any key to stop the server...");

            Console.Read();
            server.ShutdownAsync().Wait();
        }

        private static IServiceProvider StartKestrel()
        {
            var host = new WebHostBuilder()
                           .UseKestrel()
                           .UseContentRoot(Directory.GetCurrentDirectory())
                           .UseUrls("http://*:" + SharedConstants.Kestrel.ProductServiceKestrelPortNumber)
                           .UseIISIntegration()
                           .UseStartup<Startup>()
                           .Build();
           
            Task.Run(() => host.Run());

            return host.Services;
        }
    }
}
