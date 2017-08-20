using System;
using Grpc.Core;
using ECommerce.Contracts.Configuration;
using ECommerce.Services.UserService.Repositories;
using ECommerce.Services.UserService.Extensions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace ECommerce.Services.UserService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var serviceProvider = StartKestrel().SeedDatabase();

            Server server = new Server
            {
                Services = {
                    Contracts.UserService.BindService(new UserRepository(serviceProvider) )
                },
                Ports = { { "0.0.0.0", SharedConstants.GRPC.UserServiceBackendPortNumber, ServerCredentials.Insecure } }
            };

            server.Start();

            Console.WriteLine("Server listening on port " + SharedConstants.GRPC.UserServiceBackendPortNumber);
            Console.WriteLine("Press any key to stop the server...");

            Console.Read();
            server.ShutdownAsync().Wait();
        }

        private static IServiceProvider StartKestrel()
        {
            var host = new WebHostBuilder()
                           .UseKestrel()
                           .UseContentRoot(Directory.GetCurrentDirectory())
                           .UseUrls("http://*:" + SharedConstants.Kestrel.UserServiceKestrelPortNumber)
                           .UseIISIntegration()
                           .UseStartup<Startup>()
                           .Build();

            Task.Run(() => host.Run());

            return host.Services;
        }
    }
}
